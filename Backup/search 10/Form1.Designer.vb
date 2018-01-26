<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TSSiteProgress = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSLastWordAdded = New System.Windows.Forms.ToolStripStatusLabel
        Me.ButtonStart = New System.Windows.Forms.Button
        Me.ButtonResume = New System.Windows.Forms.Button
        Me.ButtonShowFolder = New System.Windows.Forms.Button
        Me.ButtonDebug = New System.Windows.Forms.Button
        Me.ButtonClearDebug = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ButtonRebuild = New System.Windows.Forms.Button
        Me.TextBoxRebuildNumber = New System.Windows.Forms.TextBox
        Me.CheckBoxShowTextWithResults = New System.Windows.Forms.CheckBox
        Me.CheckBoxTop100 = New System.Windows.Forms.CheckBox
        Me.LabelMustContain = New System.Windows.Forms.Label
        Me.TextBoxMustContain = New System.Windows.Forms.TextBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonWriteOut = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.LabelEntriesInIndex = New System.Windows.Forms.Label
        Me.LabelSitePct = New System.Windows.Forms.Label
        Me.LabelSiteProgress = New System.Windows.Forms.Label
        Me.ProgressBarSite = New System.Windows.Forms.ProgressBar
        Me.LabelDomainListPosition = New System.Windows.Forms.Label
        Me.LabelScanningHost = New System.Windows.Forms.Label
        Me.LabelHostPosition = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label0 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ButtonReloadIndex = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButtonExternal = New System.Windows.Forms.RadioButton
        Me.RadioButtonHere = New System.Windows.Forms.RadioButton
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.ButtonWriteOutSiteOnly = New System.Windows.Forms.Button
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(29, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(411, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSiteProgress, Me.TSLastWordAdded})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 464)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(622, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSiteProgress
        '
        Me.TSSiteProgress.Name = "TSSiteProgress"
        Me.TSSiteProgress.Size = New System.Drawing.Size(80, 17)
        Me.TSSiteProgress.Text = "Site Progress: "
        '
        'TSLastWordAdded
        '
        Me.TSLastWordAdded.Name = "TSLastWordAdded"
        Me.TSLastWordAdded.Size = New System.Drawing.Size(101, 17)
        Me.TSLastWordAdded.Text = "Last Word Added:"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(446, 22)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonResume
        '
        Me.ButtonResume.Location = New System.Drawing.Point(433, 51)
        Me.ButtonResume.Name = "ButtonResume"
        Me.ButtonResume.Size = New System.Drawing.Size(88, 23)
        Me.ButtonResume.TabIndex = 4
        Me.ButtonResume.Text = "Resume Last"
        Me.ButtonResume.UseVisualStyleBackColor = True
        '
        'ButtonShowFolder
        '
        Me.ButtonShowFolder.Location = New System.Drawing.Point(352, 51)
        Me.ButtonShowFolder.Name = "ButtonShowFolder"
        Me.ButtonShowFolder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonShowFolder.TabIndex = 5
        Me.ButtonShowFolder.Text = "Show Folder"
        Me.ButtonShowFolder.UseVisualStyleBackColor = True
        '
        'ButtonDebug
        '
        Me.ButtonDebug.Location = New System.Drawing.Point(433, 78)
        Me.ButtonDebug.Name = "ButtonDebug"
        Me.ButtonDebug.Size = New System.Drawing.Size(48, 23)
        Me.ButtonDebug.TabIndex = 6
        Me.ButtonDebug.Text = "Debug"
        Me.ButtonDebug.UseVisualStyleBackColor = True
        '
        'ButtonClearDebug
        '
        Me.ButtonClearDebug.Location = New System.Drawing.Point(485, 78)
        Me.ButtonClearDebug.Name = "ButtonClearDebug"
        Me.ButtonClearDebug.Size = New System.Drawing.Size(36, 23)
        Me.ButtonClearDebug.TabIndex = 7
        Me.ButtonClearDebug.Text = "CLR"
        Me.ButtonClearDebug.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 20)
        Me.TextBox2.TabIndex = 8
        '
        'ButtonRebuild
        '
        Me.ButtonRebuild.Location = New System.Drawing.Point(16, 166)
        Me.ButtonRebuild.Name = "ButtonRebuild"
        Me.ButtonRebuild.Size = New System.Drawing.Size(172, 20)
        Me.ButtonRebuild.TabIndex = 18
        Me.ButtonRebuild.Text = "Rebuild string for Ref Number.."
        Me.ButtonRebuild.UseVisualStyleBackColor = True
        '
        'TextBoxRebuildNumber
        '
        Me.TextBoxRebuildNumber.Location = New System.Drawing.Point(194, 167)
        Me.TextBoxRebuildNumber.Name = "TextBoxRebuildNumber"
        Me.TextBoxRebuildNumber.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxRebuildNumber.TabIndex = 17
        Me.TextBoxRebuildNumber.Text = "1"
        '
        'CheckBoxShowTextWithResults
        '
        Me.CheckBoxShowTextWithResults.AutoSize = True
        Me.CheckBoxShowTextWithResults.Location = New System.Drawing.Point(23, 81)
        Me.CheckBoxShowTextWithResults.Name = "CheckBoxShowTextWithResults"
        Me.CheckBoxShowTextWithResults.Size = New System.Drawing.Size(168, 17)
        Me.CheckBoxShowTextWithResults.TabIndex = 16
        Me.CheckBoxShowTextWithResults.Text = "Show Page Text With Results"
        Me.CheckBoxShowTextWithResults.UseVisualStyleBackColor = True
        '
        'CheckBoxTop100
        '
        Me.CheckBoxTop100.AutoSize = True
        Me.CheckBoxTop100.Checked = True
        Me.CheckBoxTop100.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTop100.Location = New System.Drawing.Point(23, 104)
        Me.CheckBoxTop100.Name = "CheckBoxTop100"
        Me.CheckBoxTop100.Size = New System.Drawing.Size(149, 17)
        Me.CheckBoxTop100.TabIndex = 15
        Me.CheckBoxTop100.Text = "Only return top 100 results"
        Me.CheckBoxTop100.UseVisualStyleBackColor = True
        '
        'LabelMustContain
        '
        Me.LabelMustContain.AutoSize = True
        Me.LabelMustContain.Location = New System.Drawing.Point(23, 134)
        Me.LabelMustContain.Name = "LabelMustContain"
        Me.LabelMustContain.Size = New System.Drawing.Size(96, 13)
        Me.LabelMustContain.TabIndex = 14
        Me.LabelMustContain.Text = "Link must contain.."
        '
        'TextBoxMustContain
        '
        Me.TextBoxMustContain.Location = New System.Drawing.Point(125, 131)
        Me.TextBoxMustContain.Name = "TextBoxMustContain"
        Me.TextBoxMustContain.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxMustContain.TabIndex = 13
        Me.TextBoxMustContain.Text = "/movies/"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(354, 46)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonWriteOut
        '
        Me.ButtonWriteOut.Location = New System.Drawing.Point(433, 104)
        Me.ButtonWriteOut.Name = "ButtonWriteOut"
        Me.ButtonWriteOut.Size = New System.Drawing.Size(88, 23)
        Me.ButtonWriteOut.TabIndex = 10
        Me.ButtonWriteOut.Text = "Write Out All"
        Me.ButtonWriteOut.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(352, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Errors Only"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabelEntriesInIndex
        '
        Me.LabelEntriesInIndex.AutoSize = True
        Me.LabelEntriesInIndex.Location = New System.Drawing.Point(6, 134)
        Me.LabelEntriesInIndex.Name = "LabelEntriesInIndex"
        Me.LabelEntriesInIndex.Size = New System.Drawing.Size(92, 13)
        Me.LabelEntriesInIndex.TabIndex = 39
        Me.LabelEntriesInIndex.Text = "Entries In Index: 0"
        '
        'LabelSitePct
        '
        Me.LabelSitePct.AutoSize = True
        Me.LabelSitePct.Location = New System.Drawing.Point(461, 377)
        Me.LabelSitePct.Name = "LabelSitePct"
        Me.LabelSitePct.Size = New System.Drawing.Size(21, 13)
        Me.LabelSitePct.TabIndex = 38
        Me.LabelSitePct.Text = "0%"
        '
        'LabelSiteProgress
        '
        Me.LabelSiteProgress.AutoSize = True
        Me.LabelSiteProgress.Location = New System.Drawing.Point(6, 376)
        Me.LabelSiteProgress.Name = "LabelSiteProgress"
        Me.LabelSiteProgress.Size = New System.Drawing.Size(72, 13)
        Me.LabelSiteProgress.TabIndex = 37
        Me.LabelSiteProgress.Text = "Site Progress:"
        '
        'ProgressBarSite
        '
        Me.ProgressBarSite.Location = New System.Drawing.Point(84, 376)
        Me.ProgressBarSite.Name = "ProgressBarSite"
        Me.ProgressBarSite.Size = New System.Drawing.Size(371, 14)
        Me.ProgressBarSite.TabIndex = 36
        '
        'LabelDomainListPosition
        '
        Me.LabelDomainListPosition.AutoSize = True
        Me.LabelDomainListPosition.Location = New System.Drawing.Point(6, 114)
        Me.LabelDomainListPosition.Name = "LabelDomainListPosition"
        Me.LabelDomainListPosition.Size = New System.Drawing.Size(105, 13)
        Me.LabelDomainListPosition.TabIndex = 35
        Me.LabelDomainListPosition.Text = "Domain List Position:"
        '
        'LabelScanningHost
        '
        Me.LabelScanningHost.AutoSize = True
        Me.LabelScanningHost.Location = New System.Drawing.Point(6, 74)
        Me.LabelScanningHost.Name = "LabelScanningHost"
        Me.LabelScanningHost.Size = New System.Drawing.Size(78, 13)
        Me.LabelScanningHost.TabIndex = 34
        Me.LabelScanningHost.Text = "Scanning host:"
        '
        'LabelHostPosition
        '
        Me.LabelHostPosition.AutoSize = True
        Me.LabelHostPosition.Location = New System.Drawing.Point(6, 94)
        Me.LabelHostPosition.Name = "LabelHostPosition"
        Me.LabelHostPosition.Size = New System.Drawing.Size(75, 13)
        Me.LabelHostPosition.TabIndex = 33
        Me.LabelHostPosition.Text = "Host Position: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Thread 5:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Thread 4:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Thread 3:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Thread 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Thread 1:"
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(6, 343)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(53, 13)
        Me.Label0.TabIndex = 44
        Me.Label0.Text = "Thread 0:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Thread 9:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Thread 8:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Thread 7:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Thread 6:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 439)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.ButtonWriteOutSiteOnly)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label0)
        Me.TabPage1.Controls.Add(Me.LabelSitePct)
        Me.TabPage1.Controls.Add(Me.ButtonShowFolder)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.ButtonDebug)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.ButtonResume)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ButtonClearDebug)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ButtonStart)
        Me.TabPage1.Controls.Add(Me.ButtonWriteOut)
        Me.TabPage1.Controls.Add(Me.LabelEntriesInIndex)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LabelSiteProgress)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ProgressBarSite)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.LabelDomainListPosition)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.LabelScanningHost)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.LabelHostPosition)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(584, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Spider"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.ButtonReloadIndex)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.ButtonSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(584, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonReloadIndex
        '
        Me.ButtonReloadIndex.Location = New System.Drawing.Point(340, 75)
        Me.ButtonReloadIndex.Name = "ButtonReloadIndex"
        Me.ButtonReloadIndex.Size = New System.Drawing.Size(89, 23)
        Me.ButtonReloadIndex.TabIndex = 19
        Me.ButtonReloadIndex.Text = "Reload Index"
        Me.ButtonReloadIndex.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonExternal)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHere)
        Me.GroupBox1.Controls.Add(Me.TextBoxRebuildNumber)
        Me.GroupBox1.Controls.Add(Me.ButtonRebuild)
        Me.GroupBox1.Controls.Add(Me.TextBoxMustContain)
        Me.GroupBox1.Controls.Add(Me.LabelMustContain)
        Me.GroupBox1.Controls.Add(Me.CheckBoxShowTextWithResults)
        Me.GroupBox1.Controls.Add(Me.CheckBoxTop100)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 211)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Search Options"
        '
        'RadioButtonExternal
        '
        Me.RadioButtonExternal.AutoSize = True
        Me.RadioButtonExternal.Checked = True
        Me.RadioButtonExternal.Location = New System.Drawing.Point(23, 46)
        Me.RadioButtonExternal.Name = "RadioButtonExternal"
        Me.RadioButtonExternal.Size = New System.Drawing.Size(183, 17)
        Me.RadioButtonExternal.TabIndex = 20
        Me.RadioButtonExternal.TabStop = True
        Me.RadioButtonExternal.Text = "Open Results In External Browser"
        Me.RadioButtonExternal.UseVisualStyleBackColor = True
        '
        'RadioButtonHere
        '
        Me.RadioButtonHere.AutoSize = True
        Me.RadioButtonHere.Location = New System.Drawing.Point(23, 23)
        Me.RadioButtonHere.Name = "RadioButtonHere"
        Me.RadioButtonHere.Size = New System.Drawing.Size(115, 17)
        Me.RadioButtonHere.TabIndex = 19
        Me.RadioButtonHere.Text = "Open Results Here"
        Me.RadioButtonHere.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.WebBrowser1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(584, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Browser"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(578, 407)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com/", System.UriKind.Absolute)
        '
        'ButtonWriteOutSiteOnly
        '
        Me.ButtonWriteOutSiteOnly.Location = New System.Drawing.Point(342, 104)
        Me.ButtonWriteOutSiteOnly.Name = "ButtonWriteOutSiteOnly"
        Me.ButtonWriteOutSiteOnly.Size = New System.Drawing.Size(85, 23)
        Me.ButtonWriteOutSiteOnly.TabIndex = 45
        Me.ButtonWriteOutSiteOnly.Text = "Write Out Site"
        Me.ButtonWriteOutSiteOnly.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search 10"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonResume As System.Windows.Forms.Button
    Friend WithEvents ButtonShowFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonDebug As System.Windows.Forms.Button
    Friend WithEvents ButtonClearDebug As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonRebuild As System.Windows.Forms.Button
    Friend WithEvents TextBoxRebuildNumber As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxShowTextWithResults As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTop100 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelMustContain As System.Windows.Forms.Label
    Friend WithEvents TextBoxMustContain As System.Windows.Forms.TextBox
    Friend WithEvents ButtonWriteOut As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelEntriesInIndex As System.Windows.Forms.Label
    Friend WithEvents LabelSitePct As System.Windows.Forms.Label
    Friend WithEvents LabelSiteProgress As System.Windows.Forms.Label
    Friend WithEvents ProgressBarSite As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelDomainListPosition As System.Windows.Forms.Label
    Friend WithEvents LabelScanningHost As System.Windows.Forms.Label
    Friend WithEvents LabelHostPosition As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ButtonReloadIndex As System.Windows.Forms.Button
    Friend WithEvents TSSiteProgress As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSLastWordAdded As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RadioButtonExternal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonHere As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonWriteOutSiteOnly As System.Windows.Forms.Button

End Class
