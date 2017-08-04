﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Capa_Negocio;
using Capa_Entidad;


namespace CapaPresentacion
{
    public partial class FrmEmpresa : Telerik.WinControls.UI.RadForm
    {

        //private _empCN Em
        public FrmEmpresa()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        EmpresaBL EmpCN = new EmpresaBL();


        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            cboEmpresa.DataSource = EmpCN.obtenerEmpresa();
            cboEmpresa.DisplayMember = "RazonSocial";
            cboEmpresa.ValueMember = "ID";
        }
        private void AsignarEmpresaEN() 
        {
            EmpresaEN.idEmpresa= cboEmpresa.SelectedValue.ToString();
            EmpresaEN.RazonSocial= cboEmpresa.Text;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AsignarEmpresaEN();
            FrmMenu FrmM = new FrmMenu();
            FrmM.Show();
        }
    }
}
