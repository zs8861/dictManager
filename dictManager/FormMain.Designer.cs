namespace dictManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.textBoxX_Show = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX_Import = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_GenCommonDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_GenAbbrDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_GenDisableDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ProductDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_BrandDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ShopDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_GenSynonymDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_AddrDic = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ClearData = new DevComponents.DotNetBar.ButtonX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX_RemoveEqual = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_filter1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // textBoxX_Show
            // 
            this.textBoxX_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX_Show.Border.Class = "TextBoxBorder";
            this.textBoxX_Show.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Show.Location = new System.Drawing.Point(12, 12);
            this.textBoxX_Show.Multiline = true;
            this.textBoxX_Show.Name = "textBoxX_Show";
            this.textBoxX_Show.Size = new System.Drawing.Size(710, 362);
            this.textBoxX_Show.TabIndex = 0;
            // 
            // buttonX_Import
            // 
            this.buttonX_Import.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_Import.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Import.Location = new System.Drawing.Point(12, 384);
            this.buttonX_Import.Name = "buttonX_Import";
            this.buttonX_Import.Size = new System.Drawing.Size(75, 23);
            this.buttonX_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Import.TabIndex = 1;
            this.buttonX_Import.Text = "数据导入";
            this.buttonX_Import.Click += new System.EventHandler(this.buttonX_Import_Click);
            // 
            // buttonX_GenCommonDic
            // 
            this.buttonX_GenCommonDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_GenCommonDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_GenCommonDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_GenCommonDic.Location = new System.Drawing.Point(12, 413);
            this.buttonX_GenCommonDic.Name = "buttonX_GenCommonDic";
            this.buttonX_GenCommonDic.Size = new System.Drawing.Size(356, 23);
            this.buttonX_GenCommonDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_GenCommonDic.TabIndex = 3;
            this.buttonX_GenCommonDic.Text = "生成“通用词库 Common.dic”";
            this.buttonX_GenCommonDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_GenCommonDic.Click += new System.EventHandler(this.buttonX_GenCommonDic_Click);
            // 
            // buttonX_GenAbbrDic
            // 
            this.buttonX_GenAbbrDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_GenAbbrDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_GenAbbrDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_GenAbbrDic.Location = new System.Drawing.Point(12, 442);
            this.buttonX_GenAbbrDic.Name = "buttonX_GenAbbrDic";
            this.buttonX_GenAbbrDic.Size = new System.Drawing.Size(356, 23);
            this.buttonX_GenAbbrDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_GenAbbrDic.TabIndex = 4;
            this.buttonX_GenAbbrDic.Text = "生成“缩略词库 Abbr_Category.dic Abbr_Wordlist.dic”";
            this.buttonX_GenAbbrDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_GenAbbrDic.Click += new System.EventHandler(this.buttonX_GenAbbrDic_Click);
            // 
            // buttonX_GenDisableDic
            // 
            this.buttonX_GenDisableDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_GenDisableDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_GenDisableDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_GenDisableDic.Location = new System.Drawing.Point(374, 442);
            this.buttonX_GenDisableDic.Name = "buttonX_GenDisableDic";
            this.buttonX_GenDisableDic.Size = new System.Drawing.Size(348, 23);
            this.buttonX_GenDisableDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_GenDisableDic.TabIndex = 5;
            this.buttonX_GenDisableDic.Text = "生成“停用词词库 Disable.dic”";
            this.buttonX_GenDisableDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_GenDisableDic.Click += new System.EventHandler(this.buttonX_GenDisableDic_Click);
            // 
            // buttonX_ProductDic
            // 
            this.buttonX_ProductDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ProductDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_ProductDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ProductDic.Location = new System.Drawing.Point(12, 471);
            this.buttonX_ProductDic.Name = "buttonX_ProductDic";
            this.buttonX_ProductDic.Size = new System.Drawing.Size(356, 23);
            this.buttonX_ProductDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ProductDic.TabIndex = 6;
            this.buttonX_ProductDic.Text = "生成“小商品词库 Product.dic”";
            this.buttonX_ProductDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_ProductDic.Click += new System.EventHandler(this.buttonX_ProductDic_Click);
            // 
            // buttonX_BrandDic
            // 
            this.buttonX_BrandDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_BrandDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_BrandDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_BrandDic.Location = new System.Drawing.Point(374, 471);
            this.buttonX_BrandDic.Name = "buttonX_BrandDic";
            this.buttonX_BrandDic.Size = new System.Drawing.Size(348, 23);
            this.buttonX_BrandDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_BrandDic.TabIndex = 7;
            this.buttonX_BrandDic.Text = "生成“品牌词库 Brand.dic”";
            this.buttonX_BrandDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_BrandDic.Click += new System.EventHandler(this.buttonX_BrandDic_Click);
            // 
            // buttonX_ShopDic
            // 
            this.buttonX_ShopDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ShopDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_ShopDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ShopDic.Location = new System.Drawing.Point(374, 500);
            this.buttonX_ShopDic.Name = "buttonX_ShopDic";
            this.buttonX_ShopDic.Size = new System.Drawing.Size(348, 23);
            this.buttonX_ShopDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ShopDic.TabIndex = 8;
            this.buttonX_ShopDic.Text = "生成“商铺名称词库 Shop.dic”";
            this.buttonX_ShopDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_ShopDic.Click += new System.EventHandler(this.buttonX_ShopDic_Click);
            // 
            // buttonX_GenSynonymDic
            // 
            this.buttonX_GenSynonymDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_GenSynonymDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_GenSynonymDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_GenSynonymDic.Location = new System.Drawing.Point(374, 413);
            this.buttonX_GenSynonymDic.Name = "buttonX_GenSynonymDic";
            this.buttonX_GenSynonymDic.Size = new System.Drawing.Size(348, 23);
            this.buttonX_GenSynonymDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_GenSynonymDic.TabIndex = 9;
            this.buttonX_GenSynonymDic.Text = "生成“同义词词库 Synonym.dic”";
            this.buttonX_GenSynonymDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_GenSynonymDic.Click += new System.EventHandler(this.buttonX_GenSynonymDic_Click);
            // 
            // buttonX_AddrDic
            // 
            this.buttonX_AddrDic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_AddrDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_AddrDic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_AddrDic.Location = new System.Drawing.Point(12, 500);
            this.buttonX_AddrDic.Name = "buttonX_AddrDic";
            this.buttonX_AddrDic.Size = new System.Drawing.Size(356, 23);
            this.buttonX_AddrDic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_AddrDic.TabIndex = 10;
            this.buttonX_AddrDic.Text = "生成“地名词库 Addr.dic”";
            this.buttonX_AddrDic.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX_AddrDic.Click += new System.EventHandler(this.buttonX_AddrDic_Click);
            // 
            // buttonX_ClearData
            // 
            this.buttonX_ClearData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_ClearData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ClearData.Location = new System.Drawing.Point(93, 384);
            this.buttonX_ClearData.Name = "buttonX_ClearData";
            this.buttonX_ClearData.Size = new System.Drawing.Size(75, 23);
            this.buttonX_ClearData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ClearData.TabIndex = 11;
            this.buttonX_ClearData.Text = "数据清除";
            this.buttonX_ClearData.Click += new System.EventHandler(this.buttonX_ClearData_Click);
            // 
            // progressBarX1
            // 
            this.progressBarX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.Class = "";
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(93, 526);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(629, 23);
            this.progressBarX1.TabIndex = 12;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 526);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "处理进度：";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // buttonX_RemoveEqual
            // 
            this.buttonX_RemoveEqual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_RemoveEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_RemoveEqual.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_RemoveEqual.Location = new System.Drawing.Point(551, 384);
            this.buttonX_RemoveEqual.Name = "buttonX_RemoveEqual";
            this.buttonX_RemoveEqual.Size = new System.Drawing.Size(171, 23);
            this.buttonX_RemoveEqual.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_RemoveEqual.TabIndex = 14;
            this.buttonX_RemoveEqual.Text = "近义词去重";
            this.buttonX_RemoveEqual.Click += new System.EventHandler(this.buttonX_RemoveEqual_Click);
            // 
            // buttonX_filter1
            // 
            this.buttonX_filter1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_filter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX_filter1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_filter1.Location = new System.Drawing.Point(374, 384);
            this.buttonX_filter1.Name = "buttonX_filter1";
            this.buttonX_filter1.Size = new System.Drawing.Size(171, 23);
            this.buttonX_filter1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_filter1.TabIndex = 15;
            this.buttonX_filter1.Text = "过滤去重保留分类词";
            this.buttonX_filter1.Click += new System.EventHandler(this.buttonX_filter1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 552);
            this.Controls.Add(this.buttonX_filter1);
            this.Controls.Add(this.buttonX_RemoveEqual);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.buttonX_ClearData);
            this.Controls.Add(this.buttonX_AddrDic);
            this.Controls.Add(this.buttonX_GenSynonymDic);
            this.Controls.Add(this.buttonX_ShopDic);
            this.Controls.Add(this.buttonX_BrandDic);
            this.Controls.Add(this.buttonX_ProductDic);
            this.Controls.Add(this.buttonX_GenDisableDic);
            this.Controls.Add(this.buttonX_GenAbbrDic);
            this.Controls.Add(this.buttonX_GenCommonDic);
            this.Controls.Add(this.buttonX_Import);
            this.Controls.Add(this.textBoxX_Show);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "词库入库小工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Show;
        private DevComponents.DotNetBar.ButtonX buttonX_Import;
        private DevComponents.DotNetBar.ButtonX buttonX_GenCommonDic;
        private DevComponents.DotNetBar.ButtonX buttonX_GenAbbrDic;
        private DevComponents.DotNetBar.ButtonX buttonX_GenDisableDic;
        private DevComponents.DotNetBar.ButtonX buttonX_ProductDic;
        private DevComponents.DotNetBar.ButtonX buttonX_BrandDic;
        private DevComponents.DotNetBar.ButtonX buttonX_ShopDic;
        private DevComponents.DotNetBar.ButtonX buttonX_GenSynonymDic;
        private DevComponents.DotNetBar.ButtonX buttonX_AddrDic;
        private DevComponents.DotNetBar.ButtonX buttonX_ClearData;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX_RemoveEqual;
        private DevComponents.DotNetBar.ButtonX buttonX_filter1;
    }
}

