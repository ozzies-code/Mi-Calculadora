# Project Title

Mi Calculadora
Este proyecto consiste en una calculadora sencilla

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 una calculadora para procesos matematicos basicos: suma, resta, 
 multiplicacion y division.
 
 # Actualizacion: 14/01/2025
 # Hora: 17:39

Detalles técnicos del proyecto:
Idioma: Visual C#.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo de procesos matematicos basicos en una calculadora
- diseno de una calculadora
- implementacion y puesta en practica de los metodos:
Suma, Resta, Multiplicacion y Division.

## image of the Project

![imagen](https://github.com/user-attachments/assets/d44e5c2d-2398-4c69-a26f-be6aadf44710)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

Public Class Form1

    'Declaring Variables as Integers
    Dim firstValue, secondValue As Decimal
    Dim isSuma As Boolean = False
    Dim isResta As Boolean = False
    Dim isMultpl As Boolean = False
    Dim isDiv As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text + "1"
        secondValue = Convert.ToDouble(TextBox1.Text) 'Conversiones a numeros enteros 
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text + "2"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text + "3"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text + "4"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text + "5"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text + "6"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text + "7"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text + "8"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text + "9"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text + "0"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        firstValue = Convert.ToDecimal(TextBox1.Text) 'Suma
        isSuma = True
        TextBox1.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        isSuma = False
        isResta = False 'limpieza de la pantalla
        isMultpl = False
        isDiv = False
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If isSuma = True Then 'Tostring convierte a cadena
            TextBox1.Text = firstValue + secondValue 'Equal verificar que el elemento seleccionado sea igual a la cadena de caracteres
        ElseIf isResta = True Then
            TextBox1.Text = firstValue - secondValue
        ElseIf isMultpl = True Then
            TextBox1.Text = firstValue * secondValue
        ElseIf isDiv = True Then
            TextBox1.Text = firstValue / secondValue
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        firstValue = Convert.ToDecimal(TextBox1.Text) 'Resta
        isResta = True
        TextBox1.Clear()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        firstValue = Convert.ToDecimal(TextBox1.Text) 'Multiplicacion
        isMultpl = True
        TextBox1.Clear()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstValue = Convert.ToDecimal(TextBox1.Text) 'Division
        isDiv = True
        TextBox1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False 'Inhabilitacion de la pantalla. Solo muestra las operaciones
    End Sub

    Private Sub btnPto_Click(sender As Object, e As EventArgs) Handles btnPto.Click
        TextBox1.Text += "."
        firstValue = Convert.ToDecimal(TextBox1.Text) 'uso del punto para decimales
    End Sub

End Class
