<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tk = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.Posl = New System.Windows.Forms.TextBox()
        Me.Ts = New System.Windows.Forms.TextBox()
        Me.Tsa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tk
        '
        Me.Tk.Location = New System.Drawing.Point(572, 177)
        Me.Tk.Name = "Tk"
        Me.Tk.Size = New System.Drawing.Size(100, 20)
        Me.Tk.TabIndex = 1
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(379, 372)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(118, 66)
        Me.B1.TabIndex = 2
        Me.B1.Text = "Обчислити"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Posl
        '
        Me.Posl.Location = New System.Drawing.Point(65, 37)
        Me.Posl.Multiline = True
        Me.Posl.Name = "Posl"
        Me.Posl.Size = New System.Drawing.Size(176, 347)
        Me.Posl.TabIndex = 1
        '
        'Ts
        '
        Me.Ts.Location = New System.Drawing.Point(572, 94)
        Me.Ts.Name = "Ts"
        Me.Ts.Size = New System.Drawing.Size(100, 20)
        Me.Ts.TabIndex = 1
        '
        'Tsa
        '
        Me.Tsa.Location = New System.Drawing.Point(572, 262)
        Me.Tsa.Name = "Tsa"
        Me.Tsa.Size = New System.Drawing.Size(100, 20)
        Me.Tsa.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(417, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "S"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(417, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "k"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(417, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.Posl)
        Me.Controls.Add(Me.Tsa)
        Me.Controls.Add(Me.Ts)
        Me.Controls.Add(Me.Tk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tk As TextBox
    Friend WithEvents B1 As Button
    Friend WithEvents Posl As TextBox
    Friend WithEvents Ts As TextBox
    Friend WithEvents Tsa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
