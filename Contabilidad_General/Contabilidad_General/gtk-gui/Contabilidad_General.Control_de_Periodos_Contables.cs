
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Control_de_Periodos_Contables
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label4;

		private global::Gtk.Entry txtBuscarID;

		private global::Gtk.Button btnBuscarID;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::Gtk.Entry BuscarFecha;

		private global::Gtk.Button btnBuscarFecha;

		private global::Gtk.HBox hbox5;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView tvPeriodosContables;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label8;

		private global::Gtk.Label label6;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Label label7;

		private global::Gtk.Label label9;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Entry txtIDPeriodoContable;

		private global::Gtk.Entry txtCodigoPeriodoContable;

		private global::Gtk.Entry txtFechaInicio;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Entry txtFechaFin;

		private global::Gtk.ComboBox cmbActivo;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Button btnNuevo;

		private global::Gtk.Button btnAgregar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Control_de_Periodos_Contables
			this.Name = "Contabilidad_General.Control_de_Periodos_Contables";
			this.Title = global::Mono.Unix.Catalog.GetString("Control_de_Periodos_Contables");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Control_de_Periodos_Contables.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.hbox1.Add(this.alignment2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment2]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox1.Add(this.alignment1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment1]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox1.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnSalir]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Control de Periodos Contables\n");
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por ID:");
			this.hbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.txtBuscarID = new global::Gtk.Entry();
			this.txtBuscarID.CanFocus = true;
			this.txtBuscarID.Name = "txtBuscarID";
			this.txtBuscarID.IsEditable = true;
			this.txtBuscarID.InvisibleChar = '•';
			this.hbox4.Add(this.txtBuscarID);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.txtBuscarID]));
			w7.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnBuscarID = new global::Gtk.Button();
			this.btnBuscarID.CanFocus = true;
			this.btnBuscarID.Name = "btnBuscarID";
			this.btnBuscarID.UseUnderline = true;
			this.btnBuscarID.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox4.Add(this.btnBuscarID);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnBuscarID]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
			w9.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por Fecha de inicio:");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.BuscarFecha = new global::Gtk.Entry();
			this.BuscarFecha.CanFocus = true;
			this.BuscarFecha.Name = "BuscarFecha";
			this.BuscarFecha.IsEditable = true;
			this.BuscarFecha.InvisibleChar = '•';
			this.hbox3.Add(this.BuscarFecha);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BuscarFecha]));
			w11.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.btnBuscarFecha = new global::Gtk.Button();
			this.btnBuscarFecha.CanFocus = true;
			this.btnBuscarFecha.Name = "btnBuscarFecha";
			this.btnBuscarFecha.UseUnderline = true;
			this.btnBuscarFecha.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox3.Add(this.btnBuscarFecha);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btnBuscarFecha]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.hbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox3]));
			w13.Position = 1;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.hbox5.BorderWidth = ((uint)(9));
			// Container child hbox5.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.tvPeriodosContables = new global::Gtk.TreeView();
			this.tvPeriodosContables.CanFocus = true;
			this.tvPeriodosContables.Name = "tvPeriodosContables";
			this.scrolledwindow1.Add(this.tvPeriodosContables);
			this.hbox5.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.scrolledwindow1]));
			w16.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Periodo Contable:");
			this.vbox4.Add(this.label5);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label5]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			w17.Padding = ((uint)(7));
			// Container child vbox4.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Codigo del Periodo Contable:");
			this.vbox4.Add(this.label8);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label8]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de inicio:");
			this.vbox4.Add(this.label6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label6]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(9));
			// Container child vbox4.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de fin:");
			this.vbox7.Add(this.label7);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label7]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			w20.Padding = ((uint)(15));
			// Container child vbox7.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Activo:");
			this.vbox7.Add(this.label9);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label9]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox4.Add(this.vbox7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox7]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox5.Add(this.vbox4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox4]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.txtIDPeriodoContable = new global::Gtk.Entry();
			this.txtIDPeriodoContable.CanFocus = true;
			this.txtIDPeriodoContable.Name = "txtIDPeriodoContable";
			this.txtIDPeriodoContable.IsEditable = true;
			this.txtIDPeriodoContable.InvisibleChar = '•';
			this.vbox5.Add(this.txtIDPeriodoContable);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.txtIDPeriodoContable]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.txtCodigoPeriodoContable = new global::Gtk.Entry();
			this.txtCodigoPeriodoContable.CanFocus = true;
			this.txtCodigoPeriodoContable.Name = "txtCodigoPeriodoContable";
			this.txtCodigoPeriodoContable.IsEditable = true;
			this.txtCodigoPeriodoContable.InvisibleChar = '•';
			this.vbox5.Add(this.txtCodigoPeriodoContable);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.txtCodigoPeriodoContable]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.txtFechaInicio = new global::Gtk.Entry();
			this.txtFechaInicio.CanFocus = true;
			this.txtFechaInicio.Name = "txtFechaInicio";
			this.txtFechaInicio.IsEditable = true;
			this.txtFechaInicio.InvisibleChar = '•';
			this.vbox5.Add(this.txtFechaInicio);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.txtFechaInicio]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			w26.Padding = ((uint)(3));
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.txtFechaFin = new global::Gtk.Entry();
			this.txtFechaFin.CanFocus = true;
			this.txtFechaFin.Name = "txtFechaFin";
			this.txtFechaFin.IsEditable = true;
			this.txtFechaFin.InvisibleChar = '•';
			this.vbox6.Add(this.txtFechaFin);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.txtFechaFin]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			w27.Padding = ((uint)(3));
			// Container child vbox6.Gtk.Box+BoxChild
			this.cmbActivo = global::Gtk.ComboBox.NewText();
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("Si"));
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("No"));
			this.cmbActivo.Name = "cmbActivo";
			this.cmbActivo.Active = 0;
			this.vbox6.Add(this.cmbActivo);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.cmbActivo]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			w28.Padding = ((uint)(3));
			this.vbox5.Add(this.vbox6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox6]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.hbox5.Add(this.vbox5);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox5]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox6.Add(this.alignment4);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.alignment4]));
			w33.Position = 1;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hbox7.Add(this.alignment3);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.alignment3]));
			w34.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.btnNuevo = new global::Gtk.Button();
			this.btnNuevo.CanFocus = true;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.UseUnderline = true;
			this.btnNuevo.BorderWidth = ((uint)(6));
			this.btnNuevo.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.hbox7.Add(this.btnNuevo);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.btnNuevo]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.btnAgregar = new global::Gtk.Button();
			this.btnAgregar.CanFocus = true;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.UseUnderline = true;
			this.btnAgregar.BorderWidth = ((uint)(6));
			this.btnAgregar.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox7.Add(this.btnAgregar);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.btnAgregar]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			w36.Padding = ((uint)(3));
			this.hbox6.Add(this.hbox7);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox7]));
			w37.Position = 2;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 784;
			this.DefaultHeight = 383;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
		}
	}
}
