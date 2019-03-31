<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Wiki_Search
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
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.GoSearch = New System.Windows.Forms.Button()
        Me.DisplayText = New System.Windows.Forms.RichTextBox()
        Me.ClearText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchText
        '
        Me.SearchText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchText.Location = New System.Drawing.Point(28, 427)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(256, 22)
        Me.SearchText.TabIndex = 0
        '
        'GoSearch
        '
        Me.GoSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoSearch.Location = New System.Drawing.Point(433, 425)
        Me.GoSearch.Name = "GoSearch"
        Me.GoSearch.Size = New System.Drawing.Size(75, 23)
        Me.GoSearch.TabIndex = 1
        Me.GoSearch.Text = "Search"
        Me.GoSearch.UseVisualStyleBackColor = True
        '
        'DisplayText
        '
        Me.DisplayText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayText.Location = New System.Drawing.Point(28, 42)
        Me.DisplayText.Name = "DisplayText"
        Me.DisplayText.Size = New System.Drawing.Size(480, 345)
        Me.DisplayText.TabIndex = 2
        Me.DisplayText.Text = ""
        '
        'ClearText
        '
        Me.ClearText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearText.Location = New System.Drawing.Point(337, 425)
        Me.ClearText.Name = "ClearText"
        Me.ClearText.Size = New System.Drawing.Size(75, 23)
        Me.ClearText.TabIndex = 1
        Me.ClearText.Text = "Clear"
        Me.ClearText.UseVisualStyleBackColor = True
        '
        'Form_Wiki_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 470)
        Me.Controls.Add(Me.DisplayText)
        Me.Controls.Add(Me.ClearText)
        Me.Controls.Add(Me.GoSearch)
        Me.Controls.Add(Me.SearchText)
        Me.Name = "Form_Wiki_Search"
        Me.Text = "Search Wikipedia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchText As TextBox
    Friend WithEvents GoSearch As Button
    Friend WithEvents DisplayText As RichTextBox
    Friend WithEvents ClearText As Button
End Class
