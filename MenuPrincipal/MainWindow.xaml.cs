using MaterialDesignThemes.Wpf;
using MenuPrincipal.ViewModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MenuPrincipal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var item0 = new ItemMenu("Menú Principal", new UserControl(), PackIconKind.ViewDashboard);

            var menuPedidos = new List<SubItem>
            {
                new SubItem("Pedidos Recibidos"),
                new SubItem("Estado trabajos"),
                new SubItem("Agenda")
            };
            var item1 = new ItemMenu("Gestión de Pedidos", menuPedidos, PackIconKind.ShoppingBasket);

            var menuGestionExpedientes = new List<SubItem>
            {
                new SubItem("Expedientes")
            };
            var item2 = new ItemMenu("Gestión de Expedientes", menuGestionExpedientes, PackIconKind.File);

            var menuUnidadesFisicas = new List<SubItem>
            {
                new SubItem("Recursos"),
                new SubItem("Unds. Constructivas"),
            };
            var item3 = new ItemMenu("Unidades Físicas", menuUnidadesFisicas, PackIconKind.OrderBoolAscending);

            var menuClientes = new List<SubItem>
            {
                new SubItem("Iberdrola"),
                new SubItem("Unión Fenosa")
            };
            var item4 = new ItemMenu("Clientes", menuClientes, PackIconKind.CustomerService);

            var menuUsuarios = new List<SubItem>
            {
                new SubItem("Empleados Iberdrola"),
                new SubItem("Empleado FML"),
                new SubItem("Otros")
            };
            var item5 = new ItemMenu("Usuarios", menuUsuarios, PackIconKind.Register);


            var menuConfiguracionGeneral = new List<SubItem>
            {
                new SubItem("Panel de Configuración")
            };
            var item6 = new ItemMenu("Configuración", menuConfiguracionGeneral, PackIconKind.Settings);

            Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item2));
            Menu.Children.Add(new UserControlMenuItem(item3));
            Menu.Children.Add(new UserControlMenuItem(item4));
            Menu.Children.Add(new UserControlMenuItem(item5));
            Menu.Children.Add(new UserControlMenuItem(item6));
        }
    }
}
