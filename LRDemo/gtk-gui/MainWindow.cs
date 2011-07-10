
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox layoutVBox;
	private global::Gtk.Frame apiCredentialsFrame;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.Table tblApiCredentials;
	private global::Gtk.Label lblAccountNumber;
	private global::Gtk.Label lblApiName;
	private global::Gtk.Label lblSecurityWord;
	private global::Gtk.Entry txtAccountNumber;
	private global::Gtk.Entry txtApiName;
	private global::Gtk.Entry txtSecurityWord;
	private global::Gtk.Label lblApiCredentials;
	private global::Gtk.Notebook operationsNotebook;
	private global::LRDemo.BalanceWidget balanceWidget;
	private global::Gtk.Label lblBalance;
    
	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Liberty Reserve");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.layoutVBox = new global::Gtk.VBox();
		this.layoutVBox.Name = "layoutVBox";
		this.layoutVBox.Spacing = 6;
		// Container child layoutVBox.Gtk.Box+BoxChild
		this.apiCredentialsFrame = new global::Gtk.Frame();
		this.apiCredentialsFrame.Name = "apiCredentialsFrame";
		this.apiCredentialsFrame.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child apiCredentialsFrame.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.tblApiCredentials = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
		this.tblApiCredentials.Name = "tblApiCredentials";
		this.tblApiCredentials.RowSpacing = ((uint)(6));
		this.tblApiCredentials.ColumnSpacing = ((uint)(6));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.lblAccountNumber = new global::Gtk.Label();
		this.lblAccountNumber.Name = "lblAccountNumber";
		this.lblAccountNumber.Xalign = 1F;
		this.lblAccountNumber.LabelProp = global::Mono.Unix.Catalog.GetString("Account Number:");
		this.tblApiCredentials.Add(this.lblAccountNumber);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.lblAccountNumber]));
		w1.YPadding = ((uint)(3));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.lblApiName = new global::Gtk.Label();
		this.lblApiName.Name = "lblApiName";
		this.lblApiName.Xalign = 1F;
		this.lblApiName.LabelProp = global::Mono.Unix.Catalog.GetString("API Name:");
		this.tblApiCredentials.Add(this.lblApiName);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.lblApiName]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.lblSecurityWord = new global::Gtk.Label();
		this.lblSecurityWord.Name = "lblSecurityWord";
		this.lblSecurityWord.Xalign = 1F;
		this.lblSecurityWord.LabelProp = global::Mono.Unix.Catalog.GetString("Security Word:");
		this.tblApiCredentials.Add(this.lblSecurityWord);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.lblSecurityWord]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.txtAccountNumber = new global::Gtk.Entry();
		this.txtAccountNumber.CanFocus = true;
		this.txtAccountNumber.Name = "txtAccountNumber";
		this.txtAccountNumber.IsEditable = true;
		this.txtAccountNumber.InvisibleChar = '●';
		this.tblApiCredentials.Add(this.txtAccountNumber);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.txtAccountNumber]));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.YPadding = ((uint)(3));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.txtApiName = new global::Gtk.Entry();
		this.txtApiName.CanFocus = true;
		this.txtApiName.Name = "txtApiName";
		this.txtApiName.IsEditable = true;
		this.txtApiName.InvisibleChar = '●';
		this.tblApiCredentials.Add(this.txtApiName);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.txtApiName]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tblApiCredentials.Gtk.Table+TableChild
		this.txtSecurityWord = new global::Gtk.Entry();
		this.txtSecurityWord.CanFocus = true;
		this.txtSecurityWord.Name = "txtSecurityWord";
		this.txtSecurityWord.IsEditable = true;
		this.txtSecurityWord.Visibility = false;
		this.txtSecurityWord.InvisibleChar = '●';
		this.tblApiCredentials.Add(this.txtSecurityWord);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tblApiCredentials[this.txtSecurityWord]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment.Add(this.tblApiCredentials);
		this.apiCredentialsFrame.Add(this.GtkAlignment);
		this.lblApiCredentials = new global::Gtk.Label();
		this.lblApiCredentials.Name = "lblApiCredentials";
		this.lblApiCredentials.LabelProp = global::Mono.Unix.Catalog.GetString("<b>API Credentials</b>");
		this.lblApiCredentials.UseMarkup = true;
		this.apiCredentialsFrame.LabelWidget = this.lblApiCredentials;
		this.layoutVBox.Add(this.apiCredentialsFrame);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.layoutVBox[this.apiCredentialsFrame]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		w9.Padding = ((uint)(3));
		// Container child layoutVBox.Gtk.Box+BoxChild
		this.operationsNotebook = new global::Gtk.Notebook();
		this.operationsNotebook.CanFocus = true;
		this.operationsNotebook.Name = "operationsNotebook";
		this.operationsNotebook.CurrentPage = 0;
		// Container child operationsNotebook.Gtk.Notebook+NotebookChild
		this.balanceWidget = new global::LRDemo.BalanceWidget();
		this.balanceWidget.Events = ((global::Gdk.EventMask)(256));
		this.balanceWidget.Name = "balanceWidget";
		this.operationsNotebook.Add(this.balanceWidget);
		// Notebook tab
		this.lblBalance = new global::Gtk.Label();
		this.lblBalance.Name = "lblBalance";
		this.lblBalance.LabelProp = global::Mono.Unix.Catalog.GetString("Balance");
		this.operationsNotebook.SetTabLabel(this.balanceWidget, this.lblBalance);
		this.lblBalance.ShowAll();
		this.layoutVBox.Add(this.operationsNotebook);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.layoutVBox[this.operationsNotebook]));
		w11.Position = 1;
		this.Add(this.layoutVBox);
		if ((this.Child != null)) {
			this.Child.ShowAll();
		}
		this.DefaultWidth = 602;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}