
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Control_de_Empleados
	{
		private global::Gtk.VBox vbox23;

		private global::Gtk.HBox hbox25;

		private global::Gtk.Alignment alignment27;

		private global::Gtk.Alignment alignment28;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox25;

		private global::Gtk.Label label32;

		private global::Gtk.HBox hbox27;

		private global::Gtk.HBox hbox29;

		private global::Gtk.Label label33;

		private global::Gtk.Entry txtBuscarID;

		private global::Gtk.Button btnBuscarID;

		private global::Gtk.HBox hbox28;

		private global::Gtk.Label label34;

		private global::Gtk.Entry txtBuscarNombre;

		private global::Gtk.Button btnBuscarNombre;

		private global::Gtk.HBox hbox30;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.TreeView tvEmpleados;

		private global::Gtk.VBox vbox30;

		private global::Gtk.Label label35;

		private global::Gtk.Label label36;

		private global::Gtk.Label label4;

		private global::Gtk.VBox vbox31;

		private global::Gtk.Label label37;

		private global::Gtk.Label label38;

		private global::Gtk.Label label5;

		private global::Gtk.VBox vbox32;

		private global::Gtk.Label label39;

		private global::Gtk.Label label40;

		private global::Gtk.VBox vbox33;

		private global::Gtk.Label label41;

		private global::Gtk.Label label42;

		private global::Gtk.Label label44;

		private global::Gtk.Label label45;

		private global::Gtk.VBox vbox26;

		private global::Gtk.Entry txtIDEmpleado;

		private global::Gtk.Entry txtFechaIngreso1;

		private global::Gtk.Entry txtCedulaEmpleado;

		private global::Gtk.VBox vbox27;

		private global::Gtk.Entry txtCargoEmpleado1;

		private global::Gtk.Entry txtNombresEmpleado;

		private global::Gtk.Entry txtApellidosEmpleado;

		private global::Gtk.VBox vbox28;

		private global::Gtk.Entry txtTelefonoEmpleado;

		private global::Gtk.Entry txtCelularEmpleado;

		private global::Gtk.VBox vbox29;

		private global::Gtk.Entry txtCorreoEmpleado;

		private global::Gtk.Entry txtDireccionEmpleado;

		private global::Gtk.Entry txtSueldoEmpleado;

		private global::Gtk.ComboBox cmbActivo;

		private global::Gtk.HBox hbox26;

		private global::Gtk.Alignment alignment29;

		private global::Gtk.Alignment alignment30;

		private global::Gtk.HBox hbox31;

		private global::Gtk.Button btnNuevo;

		private global::Gtk.Button btnAgregar;

		private global::Gtk.Button btnEditar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Control_de_Empleados
			this.Name = "Contabilidad_General.Control_de_Empleados";
			this.Title = global::Mono.Unix.Catalog.GetString("Control_de_Empleados");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Control_de_Empleados.Gtk.Container+ContainerChild
			this.vbox23 = new global::Gtk.VBox();
			this.vbox23.Name = "vbox23";
			this.vbox23.Spacing = 6;
			// Container child vbox23.Gtk.Box+BoxChild
			this.hbox25 = new global::Gtk.HBox();
			this.hbox25.Name = "hbox25";
			this.hbox25.Spacing = 6;
			// Container child hbox25.Gtk.Box+BoxChild
			this.alignment27 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment27.Name = "alignment27";
			this.hbox25.Add(this.alignment27);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.alignment27]));
			w1.Position = 0;
			// Container child hbox25.Gtk.Box+BoxChild
			this.alignment28 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment28.Name = "alignment28";
			this.hbox25.Add(this.alignment28);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.alignment28]));
			w2.Position = 1;
			// Container child hbox25.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox25.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.btnSalir]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox23.Add(this.hbox25);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.hbox25]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox23.Gtk.Box+BoxChild
			this.vbox25 = new global::Gtk.VBox();
			this.vbox25.Name = "vbox25";
			this.vbox25.Spacing = 6;
			// Container child vbox25.Gtk.Box+BoxChild
			this.label32 = new global::Gtk.Label();
			this.label32.Name = "label32";
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString("Control de Empleados\n");
			this.vbox25.Add(this.label32);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox25[this.label32]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox25.Gtk.Box+BoxChild
			this.hbox27 = new global::Gtk.HBox();
			this.hbox27.Name = "hbox27";
			this.hbox27.Spacing = 6;
			// Container child hbox27.Gtk.Box+BoxChild
			this.hbox29 = new global::Gtk.HBox();
			this.hbox29.Name = "hbox29";
			this.hbox29.Spacing = 6;
			// Container child hbox29.Gtk.Box+BoxChild
			this.label33 = new global::Gtk.Label();
			this.label33.Name = "label33";
			this.label33.LabelProp = global::Mono.Unix.Catalog.GetString("   Buscar por ID:");
			this.hbox29.Add(this.label33);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.label33]));
			w6.Position = 0;
			w6.Expand = false;
			// Container child hbox29.Gtk.Box+BoxChild
			this.txtBuscarID = new global::Gtk.Entry();
			this.txtBuscarID.CanFocus = true;
			this.txtBuscarID.Name = "txtBuscarID";
			this.txtBuscarID.IsEditable = true;
			this.txtBuscarID.InvisibleChar = '•';
			this.hbox29.Add(this.txtBuscarID);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.txtBuscarID]));
			w7.Position = 1;
			// Container child hbox29.Gtk.Box+BoxChild
			this.btnBuscarID = new global::Gtk.Button();
			this.btnBuscarID.CanFocus = true;
			this.btnBuscarID.Name = "btnBuscarID";
			this.btnBuscarID.UseUnderline = true;
			this.btnBuscarID.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox29.Add(this.btnBuscarID);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.btnBuscarID]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox27.Add(this.hbox29);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox27[this.hbox29]));
			w9.Position = 0;
			// Container child hbox27.Gtk.Box+BoxChild
			this.hbox28 = new global::Gtk.HBox();
			this.hbox28.Name = "hbox28";
			this.hbox28.Spacing = 6;
			// Container child hbox28.Gtk.Box+BoxChild
			this.label34 = new global::Gtk.Label();
			this.label34.Name = "label34";
			this.label34.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por Nombre:");
			this.hbox28.Add(this.label34);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.label34]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox28.Gtk.Box+BoxChild
			this.txtBuscarNombre = new global::Gtk.Entry();
			this.txtBuscarNombre.CanFocus = true;
			this.txtBuscarNombre.Name = "txtBuscarNombre";
			this.txtBuscarNombre.IsEditable = true;
			this.txtBuscarNombre.InvisibleChar = '•';
			this.hbox28.Add(this.txtBuscarNombre);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.txtBuscarNombre]));
			w11.Position = 1;
			// Container child hbox28.Gtk.Box+BoxChild
			this.btnBuscarNombre = new global::Gtk.Button();
			this.btnBuscarNombre.CanFocus = true;
			this.btnBuscarNombre.Name = "btnBuscarNombre";
			this.btnBuscarNombre.UseUnderline = true;
			this.btnBuscarNombre.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox28.Add(this.btnBuscarNombre);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.btnBuscarNombre]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.hbox27.Add(this.hbox28);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox27[this.hbox28]));
			w13.Position = 1;
			this.vbox25.Add(this.hbox27);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox25[this.hbox27]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox25.Gtk.Box+BoxChild
			this.hbox30 = new global::Gtk.HBox();
			this.hbox30.Name = "hbox30";
			this.hbox30.Spacing = 6;
			// Container child hbox30.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.scrolledwindow2.BorderWidth = ((uint)(9));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.tvEmpleados = new global::Gtk.TreeView();
			this.tvEmpleados.CanFocus = true;
			this.tvEmpleados.Name = "tvEmpleados";
			this.scrolledwindow2.Add(this.tvEmpleados);
			this.hbox30.Add(this.scrolledwindow2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.scrolledwindow2]));
			w16.Position = 0;
			// Container child hbox30.Gtk.Box+BoxChild
			this.vbox30 = new global::Gtk.VBox();
			this.vbox30.Name = "vbox30";
			this.vbox30.Spacing = 6;
			// Container child vbox30.Gtk.Box+BoxChild
			this.label35 = new global::Gtk.Label();
			this.label35.Name = "label35";
			this.label35.Xalign = 1F;
			this.label35.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Empleado:");
			this.vbox30.Add(this.label35);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.label35]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			w17.Padding = ((uint)(21));
			// Container child vbox30.Gtk.Box+BoxChild
			this.label36 = new global::Gtk.Label();
			this.label36.Name = "label36";
			this.label36.Xalign = 1F;
			this.label36.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de Ingreso:");
			this.vbox30.Add(this.label36);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.label36]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox30.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Cedula del Empleado:");
			this.vbox30.Add(this.label4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.label4]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(11));
			// Container child vbox30.Gtk.Box+BoxChild
			this.vbox31 = new global::Gtk.VBox();
			this.vbox31.Name = "vbox31";
			this.vbox31.Spacing = 6;
			// Container child vbox31.Gtk.Box+BoxChild
			this.label37 = new global::Gtk.Label();
			this.label37.Name = "label37";
			this.label37.Xalign = 1F;
			this.label37.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo del Empleado:");
			this.vbox31.Add(this.label37);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox31[this.label37]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			w20.Padding = ((uint)(5));
			// Container child vbox31.Gtk.Box+BoxChild
			this.label38 = new global::Gtk.Label();
			this.label38.Name = "label38";
			this.label38.Xalign = 1F;
			this.label38.LabelProp = global::Mono.Unix.Catalog.GetString("Nombres de Empleado:");
			this.vbox31.Add(this.label38);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox31[this.label38]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			w21.Padding = ((uint)(5));
			// Container child vbox31.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Apellidos del Empleado:");
			this.vbox31.Add(this.label5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox31[this.label5]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			w22.Padding = ((uint)(20));
			// Container child vbox31.Gtk.Box+BoxChild
			this.vbox32 = new global::Gtk.VBox();
			this.vbox32.Name = "vbox32";
			this.vbox32.Spacing = 6;
			// Container child vbox32.Gtk.Box+BoxChild
			this.label39 = new global::Gtk.Label();
			this.label39.Name = "label39";
			this.label39.Xalign = 1F;
			this.label39.LabelProp = global::Mono.Unix.Catalog.GetString("Telefono del Empleado:");
			this.vbox32.Add(this.label39);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox32[this.label39]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox32.Gtk.Box+BoxChild
			this.label40 = new global::Gtk.Label();
			this.label40.Name = "label40";
			this.label40.Xalign = 1F;
			this.label40.LabelProp = global::Mono.Unix.Catalog.GetString("Celular del Empleado:");
			this.vbox32.Add(this.label40);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox32[this.label40]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			w24.Padding = ((uint)(17));
			// Container child vbox32.Gtk.Box+BoxChild
			this.vbox33 = new global::Gtk.VBox();
			this.vbox33.Name = "vbox33";
			this.vbox33.Spacing = 6;
			// Container child vbox33.Gtk.Box+BoxChild
			this.label41 = new global::Gtk.Label();
			this.label41.Name = "label41";
			this.label41.Xalign = 1F;
			this.label41.LabelProp = global::Mono.Unix.Catalog.GetString("Correo del Empleado:");
			this.vbox33.Add(this.label41);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox33[this.label41]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox33.Gtk.Box+BoxChild
			this.label42 = new global::Gtk.Label();
			this.label42.Name = "label42";
			this.label42.Xalign = 1F;
			this.label42.LabelProp = global::Mono.Unix.Catalog.GetString("Direccion del Empleado:");
			this.vbox33.Add(this.label42);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox33[this.label42]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			w26.Padding = ((uint)(11));
			// Container child vbox33.Gtk.Box+BoxChild
			this.label44 = new global::Gtk.Label();
			this.label44.Name = "label44";
			this.label44.Xalign = 1F;
			this.label44.LabelProp = global::Mono.Unix.Catalog.GetString("Sueldo del Empleado:");
			this.vbox33.Add(this.label44);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox33[this.label44]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			w27.Padding = ((uint)(2));
			this.vbox32.Add(this.vbox33);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox32[this.vbox33]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox31.Add(this.vbox32);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox31[this.vbox32]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox30.Add(this.vbox31);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.vbox31]));
			w30.Position = 3;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox30.Gtk.Box+BoxChild
			this.label45 = new global::Gtk.Label();
			this.label45.Name = "label45";
			this.label45.Xalign = 1F;
			this.label45.LabelProp = global::Mono.Unix.Catalog.GetString("Activo:");
			this.vbox30.Add(this.label45);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.label45]));
			w31.PackType = ((global::Gtk.PackType)(1));
			w31.Position = 4;
			w31.Fill = false;
			this.hbox30.Add(this.vbox30);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.vbox30]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox30.Gtk.Box+BoxChild
			this.vbox26 = new global::Gtk.VBox();
			this.vbox26.Name = "vbox26";
			this.vbox26.Spacing = 6;
			this.vbox26.BorderWidth = ((uint)(9));
			// Container child vbox26.Gtk.Box+BoxChild
			this.txtIDEmpleado = new global::Gtk.Entry();
			this.txtIDEmpleado.CanFocus = true;
			this.txtIDEmpleado.Name = "txtIDEmpleado";
			this.txtIDEmpleado.IsEditable = true;
			this.txtIDEmpleado.InvisibleChar = '•';
			this.vbox26.Add(this.txtIDEmpleado);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.txtIDEmpleado]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			w33.Padding = ((uint)(3));
			// Container child vbox26.Gtk.Box+BoxChild
			this.txtFechaIngreso1 = new global::Gtk.Entry();
			this.txtFechaIngreso1.CanFocus = true;
			this.txtFechaIngreso1.Name = "txtFechaIngreso1";
			this.txtFechaIngreso1.IsEditable = true;
			this.txtFechaIngreso1.InvisibleChar = '•';
			this.vbox26.Add(this.txtFechaIngreso1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.txtFechaIngreso1]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			w34.Padding = ((uint)(7));
			// Container child vbox26.Gtk.Box+BoxChild
			this.txtCedulaEmpleado = new global::Gtk.Entry();
			this.txtCedulaEmpleado.CanFocus = true;
			this.txtCedulaEmpleado.Name = "txtCedulaEmpleado";
			this.txtCedulaEmpleado.IsEditable = true;
			this.txtCedulaEmpleado.InvisibleChar = '•';
			this.vbox26.Add(this.txtCedulaEmpleado);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.txtCedulaEmpleado]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			w35.Padding = ((uint)(3));
			// Container child vbox26.Gtk.Box+BoxChild
			this.vbox27 = new global::Gtk.VBox();
			this.vbox27.Name = "vbox27";
			this.vbox27.Spacing = 6;
			// Container child vbox27.Gtk.Box+BoxChild
			this.txtCargoEmpleado1 = new global::Gtk.Entry();
			this.txtCargoEmpleado1.CanFocus = true;
			this.txtCargoEmpleado1.Name = "txtCargoEmpleado1";
			this.txtCargoEmpleado1.IsEditable = true;
			this.txtCargoEmpleado1.InvisibleChar = '•';
			this.vbox27.Add(this.txtCargoEmpleado1);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.txtCargoEmpleado1]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox27.Gtk.Box+BoxChild
			this.txtNombresEmpleado = new global::Gtk.Entry();
			this.txtNombresEmpleado.CanFocus = true;
			this.txtNombresEmpleado.Name = "txtNombresEmpleado";
			this.txtNombresEmpleado.IsEditable = true;
			this.txtNombresEmpleado.InvisibleChar = '•';
			this.vbox27.Add(this.txtNombresEmpleado);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.txtNombresEmpleado]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			w37.Padding = ((uint)(5));
			// Container child vbox27.Gtk.Box+BoxChild
			this.txtApellidosEmpleado = new global::Gtk.Entry();
			this.txtApellidosEmpleado.CanFocus = true;
			this.txtApellidosEmpleado.Name = "txtApellidosEmpleado";
			this.txtApellidosEmpleado.IsEditable = true;
			this.txtApellidosEmpleado.InvisibleChar = '•';
			this.vbox27.Add(this.txtApellidosEmpleado);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.txtApellidosEmpleado]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			w38.Padding = ((uint)(3));
			// Container child vbox27.Gtk.Box+BoxChild
			this.vbox28 = new global::Gtk.VBox();
			this.vbox28.Name = "vbox28";
			this.vbox28.Spacing = 6;
			// Container child vbox28.Gtk.Box+BoxChild
			this.txtTelefonoEmpleado = new global::Gtk.Entry();
			this.txtTelefonoEmpleado.CanFocus = true;
			this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
			this.txtTelefonoEmpleado.IsEditable = true;
			this.txtTelefonoEmpleado.InvisibleChar = '•';
			this.vbox28.Add(this.txtTelefonoEmpleado);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox28[this.txtTelefonoEmpleado]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			w39.Padding = ((uint)(6));
			// Container child vbox28.Gtk.Box+BoxChild
			this.txtCelularEmpleado = new global::Gtk.Entry();
			this.txtCelularEmpleado.CanFocus = true;
			this.txtCelularEmpleado.Name = "txtCelularEmpleado";
			this.txtCelularEmpleado.IsEditable = true;
			this.txtCelularEmpleado.InvisibleChar = '•';
			this.vbox28.Add(this.txtCelularEmpleado);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox28[this.txtCelularEmpleado]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			w40.Padding = ((uint)(3));
			// Container child vbox28.Gtk.Box+BoxChild
			this.vbox29 = new global::Gtk.VBox();
			this.vbox29.Name = "vbox29";
			this.vbox29.Spacing = 6;
			// Container child vbox29.Gtk.Box+BoxChild
			this.txtCorreoEmpleado = new global::Gtk.Entry();
			this.txtCorreoEmpleado.CanFocus = true;
			this.txtCorreoEmpleado.Name = "txtCorreoEmpleado";
			this.txtCorreoEmpleado.IsEditable = true;
			this.txtCorreoEmpleado.InvisibleChar = '•';
			this.vbox29.Add(this.txtCorreoEmpleado);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox29[this.txtCorreoEmpleado]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			w41.Padding = ((uint)(3));
			// Container child vbox29.Gtk.Box+BoxChild
			this.txtDireccionEmpleado = new global::Gtk.Entry();
			this.txtDireccionEmpleado.CanFocus = true;
			this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
			this.txtDireccionEmpleado.IsEditable = true;
			this.txtDireccionEmpleado.InvisibleChar = '•';
			this.vbox29.Add(this.txtDireccionEmpleado);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox29[this.txtDireccionEmpleado]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			w42.Padding = ((uint)(2));
			// Container child vbox29.Gtk.Box+BoxChild
			this.txtSueldoEmpleado = new global::Gtk.Entry();
			this.txtSueldoEmpleado.CanFocus = true;
			this.txtSueldoEmpleado.Name = "txtSueldoEmpleado";
			this.txtSueldoEmpleado.IsEditable = true;
			this.txtSueldoEmpleado.InvisibleChar = '•';
			this.vbox29.Add(this.txtSueldoEmpleado);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox29[this.txtSueldoEmpleado]));
			w43.Position = 2;
			w43.Expand = false;
			w43.Fill = false;
			w43.Padding = ((uint)(3));
			this.vbox28.Add(this.vbox29);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox28[this.vbox29]));
			w44.Position = 2;
			w44.Expand = false;
			w44.Fill = false;
			this.vbox27.Add(this.vbox28);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.vbox28]));
			w45.Position = 3;
			w45.Expand = false;
			w45.Fill = false;
			this.vbox26.Add(this.vbox27);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.vbox27]));
			w46.Position = 3;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vbox26.Gtk.Box+BoxChild
			this.cmbActivo = global::Gtk.ComboBox.NewText();
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("Si"));
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("No"));
			this.cmbActivo.Name = "cmbActivo";
			this.cmbActivo.Active = 0;
			this.vbox26.Add(this.cmbActivo);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.cmbActivo]));
			w47.Position = 4;
			w47.Expand = false;
			w47.Fill = false;
			w47.Padding = ((uint)(1));
			this.hbox30.Add(this.vbox26);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.vbox26]));
			w48.Position = 2;
			w48.Expand = false;
			w48.Fill = false;
			this.vbox25.Add(this.hbox30);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox25[this.hbox30]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox23.Add(this.vbox25);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.vbox25]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox23.Gtk.Box+BoxChild
			this.hbox26 = new global::Gtk.HBox();
			this.hbox26.Name = "hbox26";
			this.hbox26.Spacing = 6;
			// Container child hbox26.Gtk.Box+BoxChild
			this.alignment29 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment29.Name = "alignment29";
			this.hbox26.Add(this.alignment29);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox26[this.alignment29]));
			w51.Position = 0;
			// Container child hbox26.Gtk.Box+BoxChild
			this.alignment30 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment30.Name = "alignment30";
			this.hbox26.Add(this.alignment30);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox26[this.alignment30]));
			w52.Position = 1;
			// Container child hbox26.Gtk.Box+BoxChild
			this.hbox31 = new global::Gtk.HBox();
			this.hbox31.Name = "hbox31";
			this.hbox31.Spacing = 6;
			// Container child hbox31.Gtk.Box+BoxChild
			this.btnNuevo = new global::Gtk.Button();
			this.btnNuevo.CanFocus = true;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.UseUnderline = true;
			this.btnNuevo.BorderWidth = ((uint)(6));
			this.btnNuevo.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.hbox31.Add(this.btnNuevo);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.btnNuevo]));
			w53.Position = 0;
			w53.Expand = false;
			w53.Fill = false;
			// Container child hbox31.Gtk.Box+BoxChild
			this.btnAgregar = new global::Gtk.Button();
			this.btnAgregar.CanFocus = true;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.UseUnderline = true;
			this.btnAgregar.BorderWidth = ((uint)(6));
			this.btnAgregar.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox31.Add(this.btnAgregar);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.btnAgregar]));
			w54.Position = 1;
			w54.Expand = false;
			w54.Fill = false;
			// Container child hbox31.Gtk.Box+BoxChild
			this.btnEditar = new global::Gtk.Button();
			this.btnEditar.CanFocus = true;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.UseUnderline = true;
			this.btnEditar.BorderWidth = ((uint)(6));
			this.btnEditar.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.hbox31.Add(this.btnEditar);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.btnEditar]));
			w55.Position = 2;
			w55.Expand = false;
			w55.Fill = false;
			this.hbox26.Add(this.hbox31);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox26[this.hbox31]));
			w56.Position = 2;
			w56.Expand = false;
			w56.Fill = false;
			this.vbox23.Add(this.hbox26);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.hbox26]));
			w57.Position = 2;
			w57.Expand = false;
			w57.Fill = false;
			this.Add(this.vbox23);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 850;
			this.DefaultHeight = 669;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
		}
	}
}