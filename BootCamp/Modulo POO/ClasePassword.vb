Public class Password
{
    //Utilizo varias variables entre a y z minusculas 
    Public Const longitud As Int32 
    Public Const a_minusculas As Int32 
    Public Const z_minusculas As Int32 
    Public Const a_mayusculas As Int32 
    Public Const z_mayusculas As Int32 
    Public Const z_char As Int32 
    Public Const n_chat As Int32 
    Public Const num_min_numeros As Int32 
    Public Const num_min_minusculas As Int32 
    Public Const num_min_mayusculas As int32 

    //creo una longitud para el pass
    Private longitud As Int32
    
    Private contrasenia As String

 
    //creo las propiedades get set
    public Property longitud As Integer
        Get
            Return _longitud
        End Get
        Set (value As Integer)
            _longitud =value
        End Set
    End Property

    //solamente de lectura quiero la contraseña
        
    public ReadOnly Property contrasenia As String
        Get
            Return _contrasenia
        End Get
    End Property

    
    Sub New()
        Me.longitud = LONGITUD_DEF //longitud por defecto

    End Sub

    
    Sub New(longitud As Int32)
        Me.longitud = longitud

    End Sub

    //Genero Password. No le paso por que tengo la longitud
    Private Sub generarPassword()
        Din password As String = "" //generamos pass

        For index =1 To longitud  //recorro de un hasta la longitud
            Din eleccion As Int32 = numAleatorioEntre(1,3) //
            If eleccion = 1 Then
                Din minus As Char = Convert.ToChar(numAleatorioEntre(a_minusculas, z_minusculas)) //genero un num y luego se pasa a char
                password += minus //concatena
            Elself eleccion = 2 Then
                Din mayus As Char = Convert.ToChar(numAleatorioEntre(a_mayusculas, z_mayusculas)) //genero un num y luego se pasa a char
                password += mayus//concatena
            Else 
                Din number As Char = Convert.ToChar(numAleatorioEntre(num_min_minusculas, num_min_mayusculas)) //genero un num y luego se pasa a char
                password += number//concatena

            End If

        Me._contrasenia = password // como es interno pongo esto es lo que queremos llegar

    End Sub

    //creo una funcion para saber si es fuerte creando un booleano, lo hago con un for     //each

    Function esFuerte() As Boolean
        Din minusculas As Int32 = 0
        Din mayusculas As Int32 = 0
        Din numeros As Int32 = 0
        For Each c As Char In contrasenia

	    // 
            Din code As Int32 = Convert.ToInt32(c)
            If code >= a_minusculas And code <= z_minusculas Then
                minusculas += 1
            Else If code >= a_mayusculas And code <= z_mayusculas Then
                mayusculas += 1
            Else
                numeros += 1



            End If
        Next

	
        If numeros >= num_min_numeros And minusculas >= num_min_minusculas And mayusculas >= num_min_mayusculas | Then
            Return True   
        Else
            Return False   

        End If 


    End Function



}
End class

