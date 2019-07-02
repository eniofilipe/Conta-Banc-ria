
// This file has been generated by the GUI designer. Do not modify.
namespace ContaBanco
{
	public partial class Extrato
	{
		private global::Gtk.Table table3;

		private global::Gtk.Button btnSair;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label lblCodigo;

		private global::Gtk.Label lblCpf;

		private global::Gtk.Label lblNome;

		private global::Gtk.Label lblSaldo;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ContaBanco.Extrato
			this.Name = "ContaBanco.Extrato";
			this.Title = global::Mono.Unix.Catalog.GetString("Extrato");
			this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-dnd", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(18));
			// Container child ContaBanco.Extrato.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.btnSair = new global::Gtk.Button();
			this.btnSair.CanFocus = true;
			this.btnSair.Name = "btnSair";
			this.btnSair.UseUnderline = true;
			this.btnSair.Label = global::Mono.Unix.Catalog.GetString("Sair");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-close", global::Gtk.IconSize.Menu);
			this.btnSair.Image = w1;
			this.table3.Add(this.btnSair);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.btnSair]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.table3.Add(this.hseparator1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.hseparator1]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Nome: ");
			this.table3.Add(this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("CPF: ");
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Código");
			this.table3.Add(this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label6]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Saldo: ");
			this.table3.Add(this.label7);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3[this.label7]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblCodigo = new global::Gtk.Label();
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Xalign = 1F;
			this.lblCodigo.LabelProp = global::Mono.Unix.Catalog.GetString("label10");
			this.table3.Add(this.lblCodigo);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.lblCodigo]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblCpf = new global::Gtk.Label();
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Xalign = 1F;
			this.lblCpf.LabelProp = global::Mono.Unix.Catalog.GetString("label9");
			this.table3.Add(this.lblCpf);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3[this.lblCpf]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblNome = new global::Gtk.Label();
			this.lblNome.WidthRequest = 250;
			this.lblNome.Name = "lblNome";
			this.lblNome.Xalign = 1F;
			this.lblNome.LabelProp = global::Mono.Unix.Catalog.GetString("label8");
			this.table3.Add(this.lblNome);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3[this.lblNome]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(0));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblSaldo = new global::Gtk.Label();
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Xalign = 1F;
			this.lblSaldo.LabelProp = global::Mono.Unix.Catalog.GetString("label11");
			this.table3.Add(this.lblSaldo);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.lblSaldo]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 339;
			this.DefaultHeight = 171;
			this.Show();
			this.btnSair.Clicked += new global::System.EventHandler(this.OnBtnSairClicked);
		}
	}
}
