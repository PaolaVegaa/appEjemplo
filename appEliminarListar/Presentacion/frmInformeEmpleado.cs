﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEliminarListar.Presentacion
{
    public partial class frmInformeEmpleado : Form
    {
        public frmInformeEmpleado()
        {
            InitializeComponent();
        }

        private void frmInformeEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbManageYourBusinessDataSet.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dbManageYourBusinessDataSet.empleado);

            this.reportViewer1.RefreshReport();
        }
    }
}
