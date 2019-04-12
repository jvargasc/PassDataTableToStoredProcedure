<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.DtgClients = New System.Windows.Forms.DataGridView()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.LblCustomer = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.DtgClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgClients
        '
        Me.DtgClients.AllowUserToAddRows = False
        Me.DtgClients.AllowUserToDeleteRows = False
        Me.DtgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgClients.Location = New System.Drawing.Point(15, 45)
        Me.DtgClients.Name = "DtgClients"
        Me.DtgClients.ReadOnly = True
        Me.DtgClients.Size = New System.Drawing.Size(1251, 314)
        Me.DtgClients.TabIndex = 7
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Location = New System.Drawing.Point(117, 15)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustomer.TabIndex = 0
        '
        'LblCustomer
        '
        Me.LblCustomer.Location = New System.Drawing.Point(12, 15)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(100, 23)
        Me.LblCustomer.TabIndex = 5
        Me.LblCustomer.Text = "Customer Code"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(236, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(317, 12)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 371)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.DtgClients)
        Me.Controls.Add(Me.TxtCustomer)
        Me.Controls.Add(Me.LblCustomer)
        Me.Controls.Add(Me.BtnSearch)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataTable To Stored Procedure Example"
        CType(Me.DtgClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtgClients As DataGridView
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents LblCustomer As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnClear As Button
End Class
