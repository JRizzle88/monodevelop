// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.RegexToolkit {
    
    
    public partial class RegexLibrary {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label7;
        
        private Gtk.Entry searchEntry;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.Frame frame2;
        
        private Gtk.Alignment GtkAlignment2;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView expressionsTreeview;
        
        private Gtk.Label GtkLabel2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Table table2;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Entry authorEntry;
        
        private Gtk.Label label6;
        
        private Gtk.Entry sourceEntry;
        
        private Gtk.Label label3;
        
        private Gtk.Label label5;
        
        private Gtk.Entry patternEntry;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment3;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView descriptionTextview;
        
        private Gtk.Label GtkLabel3;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Entry matchingEntry;
        
        private Gtk.Label label2;
        
        private Gtk.Entry nonMatchingEntry;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.RegexToolkit.RegexLibrary
            this.Name = "MonoDevelop.RegexToolkit.RegexLibrary";
            this.Title = Mono.Unix.Catalog.GetString("RegExLib.com Regular Expression Library");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child MonoDevelop.RegexToolkit.RegexLibrary.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Search:");
            this.hbox4.Add(this.label7);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox4[this.label7]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.searchEntry = new Gtk.Entry();
            this.searchEntry.CanFocus = true;
            this.searchEntry.Name = "searchEntry";
            this.searchEntry.IsEditable = true;
            this.searchEntry.InvisibleChar = '●';
            this.hbox4.Add(this.searchEntry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox4[this.searchEntry]));
            w3.Position = 1;
            this.vbox2.Add(this.hbox4);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 170;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.frame2 = new Gtk.Frame();
            this.frame2.Name = "frame2";
            this.frame2.ShadowType = ((Gtk.ShadowType)(0));
            this.frame2.LabelXalign = 0F;
            // Container child frame2.Gtk.Container+ContainerChild
            this.GtkAlignment2 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment2.Name = "GtkAlignment2";
            this.GtkAlignment2.LeftPadding = ((uint)(12));
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            Gtk.Viewport w5 = new Gtk.Viewport();
            w5.Name = "GtkViewport";
            w5.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.expressionsTreeview = new Gtk.TreeView();
            this.expressionsTreeview.CanFocus = true;
            this.expressionsTreeview.Name = "expressionsTreeview";
            w5.Add(this.expressionsTreeview);
            this.scrolledwindow2.Add(w5);
            this.GtkAlignment2.Add(this.scrolledwindow2);
            this.frame2.Add(this.GtkAlignment2);
            this.GtkLabel2 = new Gtk.Label();
            this.GtkLabel2.Name = "GtkLabel2";
            this.GtkLabel2.LabelProp = Mono.Unix.Catalog.GetString("<b>Expressions</b>");
            this.GtkLabel2.UseMarkup = true;
            this.frame2.LabelWidget = this.GtkLabel2;
            this.vpaned1.Add(this.frame2);
            Gtk.Paned.PanedChild w10 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.frame2]));
            w10.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.authorEntry = new Gtk.Entry();
            this.authorEntry.CanFocus = true;
            this.authorEntry.Name = "authorEntry";
            this.authorEntry.IsEditable = false;
            this.authorEntry.InvisibleChar = '●';
            this.hbox3.Add(this.authorEntry);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox3[this.authorEntry]));
            w11.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Source:");
            this.hbox3.Add(this.label6);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox3[this.label6]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.sourceEntry = new Gtk.Entry();
            this.sourceEntry.CanFocus = true;
            this.sourceEntry.Name = "sourceEntry";
            this.sourceEntry.IsEditable = false;
            this.sourceEntry.InvisibleChar = '●';
            this.hbox3.Add(this.sourceEntry);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox3[this.sourceEntry]));
            w13.Position = 2;
            this.table2.Add(this.hbox3);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table2[this.hbox3]));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Pattern:");
            this.table2.Add(this.label3);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table2[this.label3]));
            w15.TopAttach = ((uint)(1));
            w15.BottomAttach = ((uint)(2));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Author:");
            this.table2.Add(this.label5);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table2[this.label5]));
            w16.XOptions = ((Gtk.AttachOptions)(4));
            w16.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.patternEntry = new Gtk.Entry();
            this.patternEntry.CanFocus = true;
            this.patternEntry.Name = "patternEntry";
            this.patternEntry.IsEditable = false;
            this.patternEntry.InvisibleChar = '●';
            this.table2.Add(this.patternEntry);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table2[this.patternEntry]));
            w17.TopAttach = ((uint)(1));
            w17.BottomAttach = ((uint)(2));
            w17.LeftAttach = ((uint)(1));
            w17.RightAttach = ((uint)(2));
            w17.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox3.Add(this.table2);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox3[this.table2]));
            w18.Position = 0;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            this.frame1.LabelXalign = 0F;
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment3 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment3.Name = "GtkAlignment3";
            this.GtkAlignment3.LeftPadding = ((uint)(12));
            // Container child GtkAlignment3.Gtk.Container+ContainerChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow1.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.descriptionTextview = new Gtk.TextView();
            this.descriptionTextview.CanFocus = true;
            this.descriptionTextview.Name = "descriptionTextview";
            this.descriptionTextview.Editable = false;
            this.descriptionTextview.CursorVisible = false;
            this.scrolledwindow1.Add(this.descriptionTextview);
            this.GtkAlignment3.Add(this.scrolledwindow1);
            this.frame1.Add(this.GtkAlignment3);
            this.GtkLabel3 = new Gtk.Label();
            this.GtkLabel3.Name = "GtkLabel3";
            this.GtkLabel3.LabelProp = Mono.Unix.Catalog.GetString("<b>Description</b>");
            this.GtkLabel3.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel3;
            this.vbox3.Add(this.frame1);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox3[this.frame1]));
            w22.Position = 1;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Matching:");
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w23.Position = 0;
            w23.Expand = false;
            w23.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.matchingEntry = new Gtk.Entry();
            this.matchingEntry.CanFocus = true;
            this.matchingEntry.Name = "matchingEntry";
            this.matchingEntry.IsEditable = false;
            this.matchingEntry.InvisibleChar = '●';
            this.hbox1.Add(this.matchingEntry);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.hbox1[this.matchingEntry]));
            w24.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Non Matching:");
            this.hbox1.Add(this.label2);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.hbox1[this.label2]));
            w25.Position = 2;
            w25.Expand = false;
            w25.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.nonMatchingEntry = new Gtk.Entry();
            this.nonMatchingEntry.CanFocus = true;
            this.nonMatchingEntry.Name = "nonMatchingEntry";
            this.nonMatchingEntry.IsEditable = false;
            this.nonMatchingEntry.InvisibleChar = '●';
            this.hbox1.Add(this.nonMatchingEntry);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.hbox1[this.nonMatchingEntry]));
            w26.Position = 3;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w27.Position = 2;
            w27.Expand = false;
            w27.Fill = false;
            this.vpaned1.Add(this.vbox3);
            this.vbox2.Add(this.vpaned1);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vbox2[this.vpaned1]));
            w29.Position = 1;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w30.Position = 0;
            // Internal child MonoDevelop.RegexToolkit.RegexLibrary.ActionArea
            Gtk.HButtonBox w31 = this.ActionArea;
            w31.Name = "dialog1_ActionArea";
            w31.Spacing = 6;
            w31.BorderWidth = ((uint)(5));
            w31.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-close";
            this.AddActionWidget(this.buttonCancel, -7);
            Gtk.ButtonBox.ButtonBoxChild w32 = ((Gtk.ButtonBox.ButtonBoxChild)(w31[this.buttonCancel]));
            w32.Expand = false;
            w32.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-refresh";
            this.AddActionWidget(this.buttonOk, 0);
            Gtk.ButtonBox.ButtonBoxChild w33 = ((Gtk.ButtonBox.ButtonBoxChild)(w31[this.buttonOk]));
            w33.Position = 1;
            w33.Expand = false;
            w33.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 506;
            this.DefaultHeight = 473;
            this.Show();
        }
    }
}
