
Public Class Form1


    Dim cajas(100, 100) As RichTextBox
    Dim n As Integer
    Dim matriz(100, 100) As Integer
    Dim infinito As Double = 100000000000000
    Dim z As Integer
    Dim a As Integer
    Dim etiquetas = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

    ' vars grafico
    Dim matriz_grafica(100, 100) As Integer


    Dim nodos_creados As Integer = 0
    Dim linea_terminada As Boolean = True
    Dim grafo As Graphics
    Dim x_inicial As Integer
    Dim y_inicial As Integer

    Dim contenedor As PowerPacks.ShapeContainer
    Dim nodos(0) As PowerPacks.OvalShape
    Dim N_nodos As Integer = 0
    Dim aristas(0) As PowerPacks.LineShape
    Dim n_aristas As Integer = 0
    Dim arreglo_etiquetas(0) As Label
    Dim pesos_etiquetas(0) As Label
    Dim union(1) As Integer

    Dim nodo_inicial(1) As Integer
    Dim nodo_final(1) As Integer

    Function noEsta(ByVal m(,) As Integer, ByVal nodo() As Integer)
        Dim longitud As Integer = 0
        While True
            If m(longitud, 0) = -1 Then
                Exit While
            End If
            longitud += 1
        End While

        For i As Integer = 0 To longitud - 1
            If (m(i, 0) = nodo(0) And m(i, 1) = nodo(1) And m(i, 2) = nodo(2)) Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub prim(ByVal matriz(,) As Integer, ByVal a As Integer)

        Dim finales(n - 1, 2) As Integer
        Dim reserva(100, 2) As Integer
        Dim ignorados(100, 2) As Integer
        Dim terminados(n) As Boolean
        Dim nodo As Integer = a
        Dim nodosTemporales(100, 2) As Integer

        For i As Integer = 0 To 100
            ignorados(i, 0) = -1
            ignorados(i, 1) = -1
            ignorados(i, 2) = -1
            reserva(i, 0) = -1
            reserva(i, 1) = -1
            reserva(i, 2) = -1
            nodosTemporales(i, 0) = -1
            nodosTemporales(i, 1) = -1
            nodosTemporales(i, 2) = -1
        Next

        Dim posicion As Integer = 0

        For i As Integer = 0 To n
            terminados(i) = False
        Next


        While Not terminado(terminados)
            posicion = 0
            For i As Integer = 0 To n
                Dim nodo_actual() As Integer = {nodo, i, matriz(nodo, i)}
                If Not matriz(nodo, i) = 0 And ((noEsta(ignorados, nodo_actual)) And (noEsta(reserva, nodo_actual))) Then
                    nodosTemporales(posicion, 0) = nodo
                    nodosTemporales(posicion, 1) = i
                    nodosTemporales(posicion, 2) = matriz(nodo, i)
                    posicion += 1
                End If
            Next
            posicion -= 1

            ' agregar los nodos en reserva a la matriz de temporales
            Dim longitud As Integer = 0
            While True
                If reserva(longitud, 0) = -1 Then
                    Exit While
                End If
                longitud += 1
            End While
            If longitud > 0 Then
                longitud -= 1
                For i As Integer = 0 To longitud
                    nodosTemporales(posicion + 1 + i, 0) = reserva(i, 0)
                    nodosTemporales(posicion + 1 + i, 1) = reserva(i, 1)
                    nodosTemporales(posicion + 1 + i, 2) = reserva(i, 2)
                Next
            End If
            For i As Integer = 0 To 100
                reserva(i, 0) = -1
                reserva(i, 1) = -1
                reserva(i, 2) = -1
            Next
            Dim minimo() As Double = {infinito, infinito, infinito}   ' infinitos !!!!
            posicion = 0
            While True
                If nodosTemporales(posicion, 0) = -1 Then
                    Exit While
                End If
                posicion += 1
            End While
            posicion -= 1
            For i As Integer = 0 To posicion
                If nodosTemporales(i, 2) < minimo(2) Then
                    minimo(0) = nodosTemporales(i, 0)
                    minimo(1) = nodosTemporales(i, 1)
                    minimo(2) = nodosTemporales(i, 2)
                End If
            Next
            'MsgBox(minimo(0).ToString() + minimo(1).ToString() + minimo(2).ToString())

            ' agregar a finales

            For i As Integer = 0 To n - 1
                If finales(i, 2) = 0 Then
                    finales(i, 0) = minimo(0)
                    finales(i, 1) = minimo(1)
                    finales(i, 2) = minimo(2)
                    Exit For
                End If
            Next

            ' agragar nodos terminados para ser ignorados y nodos que quedan en reserva

            For i As Integer = 0 To posicion
                If nodosTemporales(i, 1) = minimo(1) Then
                    Dim j As Integer = 0
                    While True
                        If ignorados(j, 0) = -1 Then
                            ignorados(j, 0) = nodosTemporales(i, 0)
                            ignorados(j, 1) = nodosTemporales(i, 1)
                            ignorados(j, 2) = nodosTemporales(i, 2)
                            ignorados(j + 1, 0) = nodosTemporales(i, 1)
                            ignorados(j + 1, 1) = nodosTemporales(i, 0)
                            ignorados(j + 1, 2) = nodosTemporales(i, 2)
                            Exit While
                        End If
                        j += 1
                    End While
                Else
                    Dim j As Integer = 0
                    While True
                        If reserva(j, 0) = -1 Then
                            reserva(j, 0) = nodosTemporales(i, 0)
                            reserva(j, 1) = nodosTemporales(i, 1)
                            reserva(j, 2) = nodosTemporales(i, 2)
                            Exit While
                        End If
                        j += 1
                    End While
                End If
            Next
            For i As Integer = 0 To 100
                nodosTemporales(i, 0) = -1
                nodosTemporales(i, 1) = -1
                nodosTemporales(i, 2) = -1
            Next

            ' asignar el nuevo nodo 
            nodo = minimo(1)
            ' declaramos el nodo como terminado
            Dim terminado As Boolean = True
            For i As Integer = 0 To n - 1
                If finales(i, 2) = 0 Then
                    terminado = False
                End If
            Next
            If terminado Then
                Exit While
            End If


        End While

        For i As Integer = 0 To n - 1
            txt_salida_prim.AppendText(etiquetas(finales(i, 0)) + " - " + etiquetas(finales(i, 1)) + " = " + finales(i, 2).ToString())
            txt_salida_prim.AppendText(Environment.NewLine)
        Next
    End Sub

    Private Sub dijkstra(ByVal matriz(,) As Integer, ByVal a As Integer, ByVal z As Integer, ByVal n_nodos As Integer)

        Try
            Dim L(n_nodos) As Double
            Dim T(n_nodos) As Boolean
            Dim anteriores(n_nodos) As Double

            ' inicializar vectores L y T
            For i As Integer = 0 To n_nodos
                L(i) = infinito
                T(i) = False
            Next
            L(a) = 0
            Dim V As Integer = a

            ' ciclo para buscar nodos adyacentes

            While Not terminado(T)
                ' buscar nodo minimo
                V = nodoV(L, T)
                For i As Integer = 0 To n_nodos
                    If Not matriz(V, i) = 0 And Not T(i) Then

                        If (L(V) + matriz(V, i)) < L(i) Then
                            L(i) = (L(V) + matriz(V, i))
                            anteriores(i) = V

                        End If
                        'anteriores(i) = V
                        'L(i) = Math.Min(L(i), L(V) + matriz(V, i))

                        txt_log.AppendText(" " + log(L))
                        txt_log.AppendText(Environment.NewLine)
                    End If
                Next
                T(V) = True

            End While

            Dim nodo_actual As Integer = z
            Dim ruta(0) As Double
            ruta(0) = nodo_actual
            While True
                nodo_actual = anteriores(nodo_actual)
                ReDim Preserve ruta(UBound(ruta) + 1)
                ruta(UBound(ruta)) = nodo_actual


                If nodo_actual = a Then
                    Exit While
                End If
            End While
            Array.Reverse(ruta)
            txt_ruta.Text = ""
            For i As Integer = 0 To ruta.Length - 1
                If i = 0 Then
                    txt_ruta.Text = etiquetas(ruta(i))
                Else
                    txt_ruta.Text = txt_ruta.Text + " - " + etiquetas(ruta(i))
                End If
            Next

            '' eliminar controles si es que existen
            For Each ctrl As Windows.Forms.Control In salida_dijkstra.Controls
                salida_dijkstra.Controls.Remove(ctrl)
                ctrl.Dispose()
            Next


            '' crear controles nuevos
            Dim x As Integer = 0
            Dim y As Integer = 0
            Dim e(L.Length - 1) As Label
            Dim c(L.Length - 1) As TextBox
            For i As Integer = 0 To L.Length - 1
                e(i) = New Label
                e(i).Bounds = New Rectangle(New System.Drawing.Point(x + 5, y), New Size(15, 15))
                e(i).Text = etiquetas(i)

                c(i) = New TextBox
                c(i).Bounds = New Rectangle(New System.Drawing.Point(x, y + 15), New Size(30, 30))
                c(i).Text = L(i)
                salida_dijkstra.Controls.Add(c(i))
                salida_dijkstra.Controls.Add(e(i))
                x += 31
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function nodoV(ByVal L() As Double, ByVal T() As Boolean)
        Dim minimo As Double = infinito  '''' buscar como trabajar con infinitos en .net
        Dim indice As Integer = 0
        For i As Integer = 0 To L.Length - 1
            If (L(i) < minimo And Not T(i)) Then
                minimo = L(i)
                indice = i
            End If
        Next
        Return indice
    End Function


    Function terminado(ByVal T() As Boolean) As Boolean
        For i As Integer = 0 To T.Length - 1
            If Not T(i) Then
                Return False
            End If
        Next
        Return True
    End Function


    Function log(m() As Double)
        Dim valor As String
        Dim texto As String = "[ "
        For i As Integer = 0 To m.Length - 1
            valor = m(i).ToString
            If m(i) = infinito Then
                valor = "Inf"
            End If
            texto = texto + valor + "  "
        Next
        texto = texto + " ]"
        Return texto
    End Function

    Private Sub limpiar()
        For Each ctrl As Windows.Forms.Control In panel_matriz.Controls
            panel_matriz.Controls.Remove(ctrl)
            ctrl.Dispose()

        Next
        panel_matriz.Update()
        combo_A.Items.Clear()
        combo_Z.Items.Clear()
    End Sub


    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            limpiar()
            n = Integer.Parse(txt_n_nodos.Text) - 1
            If n > 26 Then
                Error 1
            End If
            Dim etiquetasH(n) As Label
            Dim etiquetasV(n) As Label
            Dim v As Integer = 10

            For i As Integer = 0 To n
                Dim h As Integer = 10
                v = v + 32
                For j As Integer = 0 To n
                    h = h + 32
                    If i = 0 Then
                        etiquetasH(j) = New Label
                        etiquetasH(j).Bounds = New Rectangle(New System.Drawing.Point(h + 5, v - 20), New Size(30, 15))
                        etiquetasH(j).Text = etiquetas(j)
                        'Me.Controls.Add(etiquetasH(j))
                        panel_matriz.Controls.Add(etiquetasH(j))
                    End If
                    If j = 0 Then
                        etiquetasV(i) = New Label
                        etiquetasV(i).Bounds = New Rectangle(New System.Drawing.Point(h - 20, v + 5), New Size(15, 15))
                        etiquetasV(i).Text = etiquetas(i)
                        'Me.Controls.Add(etiquetasV(i))
                        panel_matriz.Controls.Add(etiquetasV(i))
                    End If

                    cajas(i, j) = New RichTextBox
                    cajas(i, j).Bounds = New Rectangle(New System.Drawing.Point(h, v), New Size(30, 30))
                    cajas(i, j).SelectionFont = New Font("Calibri", 12, FontStyle.Bold)
                    cajas(i, j).BorderStyle = BorderStyle.None
                    'cajas(i, j).Font(New System.Drawing.Font(12))                     cambiar font size !
                    'Me.Controls.Add(cajas(i, j))
                    'Me.Update()
                    panel_matriz.Controls.Add(cajas(i, j))
                    panel_matriz.Update()
                Next

            Next

            '' cargar combobox
            For i As Integer = 0 To n
                combo_A.Items.Add(etiquetas(i))
                combo_Z.Items.Add(etiquetas(i))
            Next


        Catch ex As Exception
            MsgBox("Datos Invalidos")
        End Try
    End Sub

    Private Sub btn_dijkstra_Click(sender As Object, e As EventArgs) Handles btn_dijkstra.Click

        Try
            txt_log.Text = ""
            leerMatriz()
            dijkstra(matriz, a, z, n)
        Catch ex As Exception
            MsgBox("Datos Invalidos")
        End Try

    End Sub


    Private Sub btn_prim_Click(sender As Object, e As EventArgs) Handles btn_prim.Click
        Try
            txt_salida_prim.Text = ""
            leerMatriz()
            prim(matriz, a)
        Catch ex As Exception
            MsgBox("Datos Invalidos")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim test(,) As Integer = {{0, 3, 0, 1, 0}, {3, 0, 4, 0, 0}, {0, 4, 0, 2, 3}, {1, 0, 2, 0, 5}, {0, 0, 3, 5, 0}}
        For i As Integer = 0 To n
            For j As Integer = 0 To n
                cajas(i, j).Text = test(i, j)
            Next
        Next
    End Sub

    Private Sub leerMatriz()
        For i As Integer = 0 To n
            For j As Integer = 0 To n
                matriz(i, j) = Integer.Parse(cajas(i, j).Text)
            Next
        Next
        a = Integer.Parse(combo_A.SelectedIndex)
        z = Integer.Parse(combo_Z.SelectedIndex)
    End Sub




    ''
    ''    parte grafica !!!
    ''
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        grafo = grafica.CreateGraphics
        contenedor = New PowerPacks.ShapeContainer
        grafica.Controls.Add(contenedor)

        For i As Integer = 0 To 100
            For j As Integer = 0 To 100
                matriz_grafica(i, j) = -1
            Next
        Next

    End Sub

    Private Sub grafica_Click(sender As Object, e As MouseEventArgs) Handles grafica.Click
        ' establecer punto inicial
        x_inicial = e.X
        y_inicial = e.Y

        If linea_terminada Then
            nodos(N_nodos) = New PowerPacks.OvalShape
            nodos(N_nodos).Location = New Point(e.X - 25, e.Y - 25)
            nodos(N_nodos).Size = New Size(50, 50)
            nodos(N_nodos).BorderColor = Color.Red
            nodos(N_nodos).Name = N_nodos.ToString
            contenedor.Shapes.Add(nodos(N_nodos))
            ' ajustar matriz de adyacencia
            ajustarMatriz(N_nodos)
            ' agregar controlador de eventos
            AddHandler nodos(N_nodos).Click, AddressOf gestorDeAristas_Click
            AddHandler nodos(N_nodos).MouseMove, AddressOf gestorDeAristas_MouseMove

            ' ajustar combobox !
            combo_A_grafico.Items.Add(etiquetas(N_nodos))
            combo_Z_grafico.Items.Add(etiquetas(N_nodos))

            ' se agrega las respectivas etiquetas
            arreglo_etiquetas(N_nodos) = New Label
            arreglo_etiquetas(N_nodos).Bounds = New Rectangle(New Point(e.X - 8, e.Y - 8), New Size(15, 15))
            arreglo_etiquetas(N_nodos).Text = etiquetas(N_nodos)
            arreglo_etiquetas(N_nodos).Font = New Font("Calibri", 12, FontStyle.Bold)
            grafica.Controls.Add(arreglo_etiquetas(N_nodos))
            N_nodos += 1
            ReDim Preserve nodos(N_nodos)
            ReDim Preserve arreglo_etiquetas(N_nodos)

        End If

    End Sub
   


    Private Sub gestorDeAristas_MouseMove(ByVal sender As Object, ByVal m As MouseEventArgs)
        If Not linea_terminada Then
            Dim nodo_x As Integer = DirectCast(sender, PowerPacks.OvalShape).Location.X
            Dim nodo_y As Integer = DirectCast(sender, PowerPacks.OvalShape).Location.Y
            If Not nodo_inicial(0) = nodo_x Or Not nodo_inicial(1) = nodo_y Then
                linea_terminada = True
                aristas(n_aristas).X2 = DirectCast(sender, PowerPacks.OvalShape).Location.X + 25
                aristas(n_aristas).Y2 = DirectCast(sender, PowerPacks.OvalShape).Location.Y + 25
                Dim peso As Integer = Integer.Parse(InputBox("Ingrese el peso: "))
                Dim label_x As Integer = (aristas(n_aristas).X1 + aristas(n_aristas).X2) / 2
                Dim label_y As Integer = (aristas(n_aristas).Y1 + aristas(n_aristas).Y2) / 2
                pesos_etiquetas(n_aristas) = New Label
                pesos_etiquetas(n_aristas).Bounds = New Rectangle(New Point(label_x, label_y), New Size(50, 15))
                pesos_etiquetas(n_aristas).Font = New Font("Calibri", 12, FontStyle.Regular)
                pesos_etiquetas(n_aristas).Text = peso.ToString
                grafica.Controls.Add(pesos_etiquetas(n_aristas))
                union(1) = Integer.Parse(DirectCast(sender, PowerPacks.OvalShape).Name)
                grafica.Update()

                ' se ajusta la matriz
                matriz_grafica(union(0), union(1)) = peso
                matriz_grafica(union(1), union(0)) = peso


            End If
        End If
    End Sub



    Private Sub gestorDeAristas_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim x As Integer = DirectCast(sender, PowerPacks.OvalShape).Location.X

        If N_nodos > 1 Then
            If linea_terminada Then
                x_inicial = DirectCast(sender, PowerPacks.OvalShape).Location.X + 25
                y_inicial = DirectCast(sender, PowerPacks.OvalShape).Location.Y + 25
                linea_terminada = False
                nodo_inicial = {DirectCast(sender, PowerPacks.OvalShape).Location.X, DirectCast(sender, PowerPacks.OvalShape).Location.Y}
                aristas(n_aristas) = New PowerPacks.LineShape
                aristas(n_aristas).X1 = x_inicial
                aristas(n_aristas).Y1 = y_inicial
                aristas(n_aristas).BorderColor = Color.Blue
                aristas(n_aristas).BorderWidth = 2
                aristas(n_aristas).SendToBack()
                union(0) = Integer.Parse(DirectCast(sender, PowerPacks.OvalShape).Name)
            End If
        End If

    End Sub


    Private Sub grafica_MouseMove(sender As Object, e As MouseEventArgs) Handles grafica.MouseMove
        If Not linea_terminada Then
            If e.Button = Windows.Forms.MouseButtons.Left Then

                Dim x As Integer = e.X
                Dim y As Integer = e.Y

                aristas(n_aristas).X2 = x
                aristas(n_aristas).Y2 = y
                contenedor.Shapes.Add(aristas(n_aristas))
                'contenedor.Update()
            End If
        End If
    End Sub

    Private Sub ajustarMatriz(ByVal n As Integer)

        For i As Integer = 0 To n
            matriz_grafica(n, i) = 0
            matriz_grafica(i, n) = 0
        Next

    End Sub

    Private Sub dijkstra_grafico_Click(sender As Object, e As EventArgs) Handles dijkstra_grafico.Click
        a = combo_A_grafico.SelectedIndex
        z = combo_Z_grafico.SelectedIndex

        dijkstra(matriz_grafica, a, z, N_nodos - 1)
    End Sub

    Private Sub btn_prim_grafico_Click(sender As Object, e As EventArgs) Handles btn_prim_grafico.Click
        Try
            a = combo_A_grafico.SelectedIndex
            txt_salida_prim.Text = ""
            n = N_nodos - 1
            prim(matriz_grafica, a)
        Catch ex As Exception
            MsgBox("Datos Invalidos")
            MsgBox(ex.Message)
        End Try

    End Sub
End Class