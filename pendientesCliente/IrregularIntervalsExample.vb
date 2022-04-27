Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf

Namespace Winforms.Cartesian.Irregular_Intervals
    Partial Public Class IrregularIntervalsExample
        Inherits Form

        Friend WithEvents ElementHost1 As Integration.ElementHost
        Friend CartesianChart1 As CartesianChart

        Public Sub New()
            InitializeComponent()
            CartesianChart1.Series = New SeriesCollection From {
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 10),
                        New ObservablePoint(4, 7),
                        New ObservablePoint(5, 3),
                        New ObservablePoint(7, 6),
                        New ObservablePoint(10, 8)
                    },
                    .PointGeometrySize = 15
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 2),
                        New ObservablePoint(2, 5),
                        New ObservablePoint(3, 6),
                        New ObservablePoint(6, 8),
                        New ObservablePoint(10, 5)
                    },
                    .PointGeometrySize = 15
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                }
            }
        End Sub

        Private Sub InitializeComponent()
            Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
            Me.CartesianChart1 = New LiveCharts.Wpf.CartesianChart()
            Me.SuspendLayout()
            '
            'ElementHost1
            '
            Me.ElementHost1.Location = New System.Drawing.Point(50, 29)
            Me.ElementHost1.Name = "ElementHost1"
            Me.ElementHost1.Size = New System.Drawing.Size(483, 279)
            Me.ElementHost1.TabIndex = 0
            Me.ElementHost1.Text = "ElementHost1"
            Me.ElementHost1.Child = Me.CartesianChart1
            '
            'IrregularIntervalsExample
            '
            Me.ClientSize = New System.Drawing.Size(553, 380)
            Me.Controls.Add(Me.ElementHost1)
            Me.Name = "IrregularIntervalsExample"
            Me.ResumeLayout(False)

        End Sub


    End Class
End Namespace
