using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONetEF
{
    public partial class OperacionesUnarias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar el objeto para el mapeado objeto relacional
        private NorthwindEntities nor = new NorthwindEntities();
        protected void gvConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnConsulta1_Click(object sender, EventArgs e)
        {
            var consulta = from C in nor.Products
                           select C;
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta2_Click(object sender, EventArgs e)
        {
            var consulta = from C in nor.Products
                           where C.UnitPrice >= 50
                           select C;
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta3_Click(object sender, EventArgs e)
        {
            var consulta = from p in nor.Products
                           where p.QuantityPerUnit.Contains("bottles") && p.UnitsInStock > 20
                           select p;

            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta4_Click(object sender, EventArgs e)
        {
            var consulta = from P in nor.Orders
                           select new
                           {
                               IDPedido = P.OrderID, 
                               FechaOrden = P.OrderDate, 
                               CodigoCliente = P.CustomerID 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta5_Click(object sender, EventArgs e)
        {
            var consulta = from Prod in nor.Products
                           select new
                           {
                               CodigoProducto = Prod.ProductID, 
                               NombreProducto = Prod.ProductName, 
                               PrecioUnitario = Prod.UnitPrice 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta6_Click(object sender, EventArgs e)
        {
            var consulta = from E in nor.Employees
                           select new
                           {
                               IDEmpleado = E.EmployeeID, 
                               NombreCompleto = E.FirstName + " " + E.LastName, 
                               Cargo = E.Title 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta7_Click(object sender, EventArgs e)
        {
            var consulta = from Prod in nor.Products
                           select new
                           {
                               NuevoNombreProducto = Prod.ProductName, 
                               PrecioUnitario = Prod.UnitPrice 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta8_Click(object sender, EventArgs e)
        {
            var consulta = from P in nor.Orders
                           select new
                           {
                               FechaOrden = P.OrderDate, 
                               CodigoCliente = P.CustomerID 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta9_Click(object sender, EventArgs e)
        {
            var consulta = from E in nor.Employees
                           select new
                           {
                               IDEmpleado = E.EmployeeID, 
                               NombreCompleto = E.FirstName + " " + E.LastName 
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }
    }

}