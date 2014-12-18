using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.ConnectionUI;
using System.Data.SqlClient;

namespace WpfApplicationTest
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class Window1 : Window
  {
    public Window1()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      {
        DataConnectionDialog dcd = new DataConnectionDialog(InitMode.All);
        dcd.ConnectionString = cs.Text;
        if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
        {
          cs.Text = dcd.ConnectionString;
        }
      }
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      DataConnectionDialog dcd = new DataConnectionDialog(InitMode.OnlyMsSql);
      dcd.ConnectionString = cs.Text;
      if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
      { cs.Text = dcd.ConnectionString; }
    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
      DataConnectionDialog dcd = new DataConnectionDialog(InitMode.OnlyOracle);
      dcd.ConnectionString = cs.Text;
      if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
      {
        cs.Text = dcd.ConnectionString;
      }

    }
  }
}
