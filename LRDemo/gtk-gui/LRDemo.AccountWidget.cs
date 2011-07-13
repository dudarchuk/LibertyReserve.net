
// This file has been generated by the GUI designer. Do not modify.
namespace LRDemo
{
	public partial class AccountWidget
	{
		private global::Gtk.Table tblLayout;
		private global::Gtk.Table tblAccountRequest;
		private global::Gtk.Frame operationParamsFrame;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table tblBalanceOperation;
		private global::Gtk.Label lblAccountNumber;
		private global::Gtk.Label lblAccountToRetrieve;
		private global::Gtk.Entry txtAccountNumber;
		private global::Gtk.Entry txtAccountToRetrieve;
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
		private global::Gtk.Frame accountsFrame;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.NodeView accountsNodeView;
		private global::Gtk.Label lblAccounts;
		private global::Gtk.Frame rawResponseFrame;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView txtRawResponse;
		private global::Gtk.Label lblRowResponse;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LRDemo.AccountWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LRDemo.AccountWidget";
			// Container child LRDemo.AccountWidget.Gtk.Container+ContainerChild
			this.tblLayout = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.tblLayout.Name = "tblLayout";
			this.tblLayout.RowSpacing = ((uint)(6));
			this.tblLayout.ColumnSpacing = ((uint)(6));
			// Container child tblLayout.Gtk.Table+TableChild
			this.tblAccountRequest = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.tblAccountRequest.Name = "tblAccountRequest";
			this.tblAccountRequest.RowSpacing = ((uint)(6));
			this.tblAccountRequest.ColumnSpacing = ((uint)(6));
			// Container child tblAccountRequest.Gtk.Table+TableChild
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
			this.lblAccountNumber = new global::Gtk.Label ();
			this.lblAccountNumber.Name = "lblAccountNumber";
			this.lblAccountNumber.Xalign = 1F;
			this.lblAccountNumber.LabelProp = global::Mono.Unix.Catalog.GetString ("Account Number:");
			this.tblBalanceOperation.Add (this.lblAccountNumber);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.lblAccountNumber]));
			w1.YPadding = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.lblAccountToRetrieve = new global::Gtk.Label ();
			this.lblAccountToRetrieve.Name = "lblAccountToRetrieve";
			this.lblAccountToRetrieve.Xalign = 1F;
			this.lblAccountToRetrieve.LabelProp = global::Mono.Unix.Catalog.GetString ("Account To Retrieve:");
			this.tblBalanceOperation.Add (this.lblAccountToRetrieve);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.lblAccountToRetrieve]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.txtAccountNumber = new global::Gtk.Entry ();
			this.txtAccountNumber.CanFocus = true;
			this.txtAccountNumber.Name = "txtAccountNumber";
			this.txtAccountNumber.IsEditable = true;
			this.txtAccountNumber.InvisibleChar = '●';
			this.tblBalanceOperation.Add (this.txtAccountNumber);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.txtAccountNumber]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YPadding = ((uint)(3));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblBalanceOperation.Gtk.Table+TableChild
			this.txtAccountToRetrieve = new global::Gtk.Entry ();
			this.txtAccountToRetrieve.CanFocus = true;
			this.txtAccountToRetrieve.Name = "txtAccountToRetrieve";
			this.txtAccountToRetrieve.IsEditable = true;
			this.txtAccountToRetrieve.InvisibleChar = '●';
			this.tblBalanceOperation.Add (this.txtAccountToRetrieve);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblBalanceOperation [this.txtAccountToRetrieve]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.tblBalanceOperation);
			this.operationParamsFrame.Add (this.GtkAlignment);
			this.operationParameters = new global::Gtk.Label ();
			this.operationParameters.Name = "operationParameters";
			this.operationParameters.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Operation Parameters</b>");
			this.operationParameters.UseMarkup = true;
			this.operationParamsFrame.LabelWidget = this.operationParameters;
			this.tblAccountRequest.Add (this.operationParamsFrame);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tblAccountRequest [this.operationParamsFrame]));
			w7.XPadding = ((uint)(3));
			w7.YPadding = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAccountRequest.Gtk.Table+TableChild
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
			this.tblAccountRequest.Add (this.pnlOperationButtons);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tblAccountRequest [this.pnlOperationButtons]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YPadding = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAccountRequest.Gtk.Table+TableChild
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
			this.tblAccountRequest.Add (this.requestOperationsFrame);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tblAccountRequest [this.requestOperationsFrame]));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.YPadding = ((uint)(3));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.tblLayout.Add (this.tblAccountRequest);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tblLayout [this.tblAccountRequest]));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblLayout.Gtk.Table+TableChild
			this.tblResponse = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tblResponse.Name = "tblResponse";
			this.tblResponse.RowSpacing = ((uint)(6));
			this.tblResponse.ColumnSpacing = ((uint)(6));
			// Container child tblResponse.Gtk.Table+TableChild
			this.accountsFrame = new global::Gtk.Frame ();
			this.accountsFrame.Name = "accountsFrame";
			this.accountsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child accountsFrame.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.accountsNodeView = new global::Gtk.NodeView ();
			this.accountsNodeView.CanFocus = true;
			this.accountsNodeView.Name = "accountsNodeView";
			this.GtkScrolledWindow2.Add (this.accountsNodeView);
			this.GtkAlignment3.Add (this.GtkScrolledWindow2);
			this.accountsFrame.Add (this.GtkAlignment3);
			this.lblAccounts = new global::Gtk.Label ();
			this.lblAccounts.Name = "lblAccounts";
			this.lblAccounts.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Accounts</b>");
			this.lblAccounts.UseMarkup = true;
			this.accountsFrame.LabelWidget = this.lblAccounts;
			this.tblResponse.Add (this.accountsFrame);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tblResponse [this.accountsFrame]));
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
