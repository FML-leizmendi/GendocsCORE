﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GendocsForms
{
    public partial class ClsPedidos
    {
        public int IdPedidoCab { get; set; }
        public string NumRef { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaPedido { get; set; }
        public int? IdEmpleadoGestor { get; set; }
        public string Gestor { get; set; }
        public string NumContrato { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string NumObra { get; set; }
        public string DescripcionObra { get; set; }
        public string Actuacion { get; set; }
        public string Provincia { get; set; }
        public string Poblacion { get; set; }
        public string Direccion { get; set; }
        public int? IdProyecto { get; set; }
        public int? IvaSn { get; set; }
        public decimal? TotalImporte { get; set; }
        public string FilePdf { get; set; }
        public string Txt1 { get; set; }
        public string Txt2 { get; set; }
        public decimal? CoeficientePrecio { get; set; }
        public decimal? CoeficienteFacturacion { get; set; }

        public List<int> lstId = new List<int>();

        public bool esNuevo = false;

        public bool EsAlta = false;

        public int Cantidad;

        public void CargarFrmPedidos()
        {
            FrmPedidos frm = new FrmPedidos(this);
           // IdPedidoCab = lstId[0];
            frm.ShowDialog();
        }

        public void ProcesaTxt(String Texto)
        {
            try
            {
                FrmPedidosEntrantes frm = new FrmPedidosEntrantes();
                if (frm.BuscaTXT(Texto, 1, "IBERDROLA DISTRIBUCION ELECTRICA, S.A.U.", 0, ""))
                {
                    IdCliente = 1;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
