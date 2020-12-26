﻿Imports System.Data.OracleClient
Public Class TransaksiPR
    Public barisdgv As Integer = 0
    Public keterangan As String
    Dim bantu As Integer

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Sub Isikode() 'Untuk memberi kode Transaksi PR
        Dim month As String = Format(DateTimePicker1.Value, "MM")
        Dim year As String = Format(DateTimePicker1.Value, "yy")
        Dim year1 As String = Format(DateTimePicker1.Value, "yyyy") 'INI
        Dim gabungan As String = year + month
        Dim cari As String = month + "/" + year1 'INI
        TxtKode.Text = ""
        Try
            Dim bant As String = ""
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select max(to_number(substr(KODE_TRANSAKSIPR,11,20)))+1 from t_pr where date_pr like '%" & cari & "%'", conn) 'INI
#Enable Warning BC40000 ' Type or member is obsolete
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 4 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            CloseConn("all")
            TxtKode.Text = "PRSP/" & gabungan & "/" & bant & TxtKode.Text
        Catch ex As Exception
            TxtKode.Text = "PRSP/" & gabungan & "/" & "0001"
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Isikode()
    End Sub

    Private Sub TransaksiPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Isikode()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Dim sql As String
            For baris = 0 To DataGridView1.Rows.Count - 2
                sql = "Insert Into T_pr values ('" & DataGridView1.Rows(baris).Cells(0).Value & "','" & TxtKode.Text & "','" & DateTimePicker1.Value & "','" & ComboReqShipment.Text & "','" & ComboPRType.Text & "','" & ComboSubPR.Text & "','" & ComboReqBy.Text & "','" & DataGridView1.Rows(baris).Cells(2).Value & "','" & DataGridView1.Rows(baris).Cells(4).Value & "','" & DataGridView1.Rows(baris).Cells(6).Value & "','" & TxtCatatan.Text & "','Belum Diproses')"
#Disable Warning BC40000 ' Type or member is obsolete
                Dim cmd As New OracleCommand(sql, conn)
#Enable Warning BC40000 ' Type or member is obsolete
                cmd.ExecuteNonQuery()
                CloseConn("cmd")
            Next
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PRRV.TxtKode.Text = TxtKode.Text
            Me.Hide()
            PRRV.ShowDialog() 'Untuk membuat surat Purchase Request
            'Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Close()
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        keterangan = "bacot"
        Dim autoText As TextBox = TryCast(e.Control, TextBox)
        If autoText IsNot Nothing Then
            autoText.AutoCompleteMode = AutoCompleteMode.Suggest
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim DataCollection As New AutoCompleteStringCollection()
            AddItems(DataCollection)
            autoText.AutoCompleteCustomSource = DataCollection
        End If
    End Sub

    Private Sub AddItems(ByVal col As AutoCompleteStringCollection) 'Untuk autocomplete
#Disable Warning BC40000 ' Type or member is obsolete
        cmd = New OracleCommand("select * from Kategori_SPAREPART", conn)
#Enable Warning BC40000 ' Type or member is obsolete
        dr = cmd.ExecuteReader()
        While dr.Read()
            col.Add(dr.Item(0) + " " + dr.Item(1))
        End While
        CloseConn("all")
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Tab Then
            Isidgvcol()
        End If
        CloseConn("all")
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If keterangan = "bacot" Then
            Isidgvcol()
        End If
        CloseConn("all")
    End Sub

    Private Sub Isidgvcol()
#Disable Warning BC40000 ' Type or member is obsolete
        cmd = New OracleCommand("select * from kategori_sparepart where kode_kategori = SUBSTR('" & DataGridView1.Rows(barisdgv).Cells(0).Value & "',1,5)", conn)
#Enable Warning BC40000 ' Type or member is obsolete
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            If DataGridView1.AllowUserToAddRows = True Then
                If DataGridView1.Rows(barisdgv).Cells(0).Value IsNot Nothing And DataGridView1.Rows(barisdgv).Cells(2).Value Is Nothing Then
                    'Isi data di kolom
                    DataGridView1.Rows(barisdgv).Cells(0).Value = dr.Item(0)
                    DataGridView1.Rows(barisdgv).Cells(1).Value = dr.Item(1)
                    DataGridView1.Rows(barisdgv).Cells(3).Value = dr.Item(2)
                    DataGridView1.Rows(barisdgv).Cells(5).Value = dr.Item(3)
                    DataGridView1.Rows(barisdgv).Cells(7).Value = dr.Item(6)
                    barisdgv += 1
                End If
                Try 'Penghitung qty
                    For penghitung = 0 To barisdgv - 1
                        bantu = CInt(DataGridView1.Rows(penghitung).Cells(2).Value) * CInt(DataGridView1.Rows(penghitung).Cells(7).Value)
                        DataGridView1.Rows(penghitung).Cells(4).Value = bantu
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Produk tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            keterangan = "tocab"
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class