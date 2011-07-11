
// This file has been generated by the GUI designer. Do not modify.
namespace LRDemo
{
	public partial class BalanceWidget
	{
		private global::Gtk.Table tblLayout;
		private global::Gtk.Table tblBalanceRequest;
		private global::Gtk.Frame operationParamsFrame;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table tblBalanceOperation;
		private global::Gtk.ComboBox cmbCurrency;
		private global::Gtk.Label lblAccountNumber;
		private global::Gtk.Label lblCurrency;
		private global::Gtk.Entry txtAccountNumber;
		private global::Gtk.Label operationParameters;
		private global::Gtk.VButtonBox pnlOperationButtons;
		private global::Gtk.Button btnAddOperation;
		private global::Gtk.Button btnRemoveOperation;
		private global::Gtk.Button btnSendRequest;
		private global::Gtk.Frame requestOperationsFrame;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView operationsNodeView;
		private global::Gtk.Label lblRequestOperations;
		private global::Gtk.Table tblResponse;
		private global::Gtk.Frame balanceFrame;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.NodeView balanceNodeView;
		private global::Gtk.Label lblBalance;
		private global::Gtk.Frame rawResponseFrame;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView txtRawResponse;
		private global::Gtk.Label lblRowResponse;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LRDemo.BalanceWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LRDemo.BalanceWidget";
			// Container child LRDemo.BalanceWidget.Gtk.Container+ContainerChild
			this.tblLayout = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.tblLayout.Name = "tblLayout";
			this.tblLayout.RowSpacing = ((uint)(6));
			this.tblLayout.ColumnSpacing = ((uint)(6));
			// Container child tblLayout.Gtk.Table+TableChild
			this.tblBalanceRequest = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.tblBalanceRequest.Name = "tblBalanceRequest";
			this.tblBalanceRequest.RowSpacing = ((uint)(6));
			this.tblBalanceRequest.ColumnSpacing = ((uint)(6));
			// Container child tblBalanceRequest.Gtk.Table+TableChild
			this.operationParamsFrame = new global::Gtk.Frame ();
			this.operationParamsFrame.Name = "operationParamsFrame";
			this.operationParamsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child operationParamsFrame.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.tblBalanceOperation = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.tblBalanceOperation.Name = "tblBalanceOperation";
			this.tblBalanceOperation.RowSpacing = ((uint)(6));
			this.tblBalanceOperation.ColumnSpacing = ((uint)(6));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.cmbCurrency = global::Gtk.ComboBox.NewText ();
			this.cmbCurrency.Name = "cmbCurrency";
			this.cmbCurrency.HasFrame = false;
			this.tblBalanceOperation.Add (this.cmbCurrency);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.cmbCurrency]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.lblAccountNumber = new global::Gtk.Label ();
			this.lblAccountNumber.Name = "lblAccountNumber";
			this.lblAccountNumber.Xalign = 1F;
			this.lblAccountNumber.LabelProp = global::Mono.Unix.Catalog.GetString ("Account Number:");
			this.tblBalanceOperation.Add (this.lblAccountNumber);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.lblAccountNumber]));
			w2.YPadding = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.lblCurrency = new global::Gtk.Label ();
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Xalign = 1F;
			this.lblCurrency.LabelProp = global::Mono.Unix.Catalog.GetString ("Currency:");
			this.tblBalanceOperation.Add (this.lblCurrency);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.lblCurrency]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.txtAccountNumber = new global::Gtk.Entry ();
			this.txtAccountNumber.CanFocus = true;
			this.txtAccountNumber.Name = "txtAccountNumber";
			this.txtAccountNumber.IsEditable = true;
			this.txtAccountNumber.InvisibleChar = '●';
			this.tblBalanceOperation.Add (this.txtAccountNumber);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.txtAccountNumber]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YPadding = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.tblBalanceOperation);
			this.operationParamsFrame.Add (this.GtkAlignment);
			this.operationParameters = new global::Gtk.Label ();
			this.operationParameters.Name = "operationParameters";
			this.operationParameters.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Operation Parameters</b>");
			this.operationParameters.UseMarkup = true;
			this.operationParamsFrame.LabelWidget = this.operationParameters;
			this.tblBalanceRequest.Add (this.operationParamsFrame);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tblBalanceRequest [this.operationParamsFrame]));
			w7.XPadding = ((uint)(3));
			w7.YPadding = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceRequest.Gtk.Table+TableChild
			this.pnlOperationButtons = new global::Gtk.VButtonBox ();
			this.pnlOperationButtons.Name = "pnlOperationButtons";
			this.pnlOperationButtons.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child pnlOperationButtons.Gtk.ButtonBox+ButtonBoxChild
			this.btnAddOperation = new global::Gtk.Button ();
			this.btnAddOperation.CanFocus = true;
			this.btnAddOperation.Name = "btnAddOperation";
			this.btnAddOperation.UseUnderline = true;
			this.btnAddOperation.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.pnlOperationButtons.Add (this.btnAddOperation);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.pnlOperationButtons [this.btnAddOperation]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child pnlOperationButtons.Gtk.ButtonBox+ButtonBoxChild
			this.btnRemoveOperation = new global::Gtk.Button ();
			this.btnRemoveOperation.CanFocus = true;
			this.btnRemoveOperation.Name = "btnRemoveOperation";
			this.btnRemoveOperation.UseUnderline = true;
			this.btnRemoveOperation.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.pnlOperationButtons.Add (this.btnRemoveOperation);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.pnlOperationButtons [this.btnRemoveOperation]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child pnlOperationButtons.Gtk.ButtonBox+ButtonBoxChild
			this.btnSendRequest = new global::Gtk.Button ();
			this.btnSendRequest.CanFocus = true;
			this.btnSendRequest.Name = "btnSendRequest";
			this.btnSendRequest.UseUnderline = true;
			this.btnSendRequest.Label = global::Mono.Unix.Catalog.GetString ("Send");
			this.pnlOperationButtons.Add (this.btnSendRequest);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.pnlOperationButtons [this.btnSendRequest]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.tblBalanceRequest.Add (this.pnlOperationButtons);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tblBalanceRequest [this.pnlOperationButtons]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YPadding = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceRequest.Gtk.Table+TableChild
			this.requestOperationsFrame = new global::Gtk.Frame ();
			this.requestOperationsFrame.Name = "requestOperationsFrame";
			this.requestOperationsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child requestOperationsFrame.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.GtkAlignment1.TopPadding = ((uint)(3));
			this.GtkAlignment1.RightPadding = ((uint)(3));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.operationsNodeView = new global::Gtk.NodeView ();
			this.operationsNodeView.CanFocus = true;
			this.operationsNodeView.Name = "operationsNodeView";
			this.GtkScrolledWindow.Add (this.operationsNodeView);
			this.GtkAlignment1.Add (this.GtkScrolledWindow);
			this.requestOperationsFrame.Add (this.GtkAlignment1);
			this.lblRequestOperations = new global::Gtk.Label ();
			this.lblRequestOperations.Name = "lblRequestOperations";
			this.lblRequestOperations.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Operations In Request</b>");
			this.lblRequestOperations.UseMarkup = true;
			this.requestOperationsFrame.LabelWidget = this.lblRequestOperations;
			this.tblBalanceRequest.Add (this.requestOperationsFrame);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tblBalanceRequest [this.requestOperationsFrame]));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.YPadding = ((uint)(3));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.tblLayout.Add (this.tblBalanceRequest);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tblLayout [this.tblBalanceRequest]));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblLayout.Gtk.Table+TableChild
			this.tblResponse = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tblResponse.Name = "tblResponse";
			this.tblResponse.RowSpacing = ((uint)(6));
			this.tblResponse.ColumnSpacing = ((uint)(6));
			// Container child tblResponse.Gtk.Table+TableChild
			this.balanceFrame = new global::Gtk.Frame ();
			this.balanceFrame.Name = "balanceFrame";
			this.balanceFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child balanceFrame.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.balanceNodeView = new global::Gtk.NodeView ();
			this.balanceNodeView.CanFocus = true;
			this.balanceNodeView.Name = "balanceNodeView";
			this.GtkScrolledWindow2.Add (this.balanceNodeView);
			this.GtkAlignment3.Add (this.GtkScrolledWindow2);
			this.balanceFrame.Add (this.GtkAlignment3);
			this.lblBalance = new global::Gtk.Label ();
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Balance</b>");
			this.lblBalance.UseMarkup = true;
			this.balanceFrame.LabelWidget = this.lblBalance;
			this.tblResponse.Add (this.balanceFrame);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tblResponse [this.balanceFrame]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			// Container child tblResponse.Gtk.Table+TableChild
			this.rawResponseFrame = new global::Gtk.Frame ();
			this.rawResponseFrame.Name = "rawResponseFrame";
			this.rawResponseFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child rawResponseFrame.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.txtRawResponse = new global::Gtk.TextView ();
			this.txtRawResponse.CanFocus = true;
			this.txtRawResponse.Name = "txtRawResponse";
			this.txtRawResponse.Editable = false;
			this.txtRawResponse.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow1.Add (this.txtRawResponse);
			this.GtkAlignment2.Add (this.GtkScrolledWindow1);
			this.rawResponseFrame.Add (this.GtkAlignment2);
			this.lblRowResponse = new global::Gtk.Label ();
			this.lblRowResponse.Name = "lblRowResponse";
			this.lblRowResponse.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Raw Response</b>");
			this.lblRowResponse.UseMarkup = true;
			this.rawResponseFrame.LabelWidget = this.lblRowResponse;
			this.tblResponse.Add (this.rawResponseFrame);
			this.tblLayout.Add (this.tblResponse);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.tblLayout [this.tblResponse]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			this.Add (this.tblLayout);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.btnAddOperation.Clicked += new global::System.EventHandler (this.OnAddOperationClicked);
			this.btnRemoveOperation.Clicked += new global::System.EventHandler (this.OnRemoveOperationClicked);
			this.btnSendRequest.Clicked += new global::System.EventHandler (this.OnSendRequestClicked);
		}
	}
}
