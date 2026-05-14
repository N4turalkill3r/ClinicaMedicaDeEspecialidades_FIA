// Arreglos de las clases para guardar los  datos de las citas médicas

string[] nombresPacientes = new string[100]; // (nombresPacientes que se registren en el sistema, máximo 100 pacientes)
string[] codigosCitas = new string[200];    // Formato C-000X
string[] nombresMedicos = new string[10]; // 10 medicos disponibles, 5 especialistas y 5 generales para traige y consulta general.
string[] fechasCitas = new string[100];     // DD/MM/AAAA
int[] edades = new int[100];
int[] especialidades = new int[125];       // Códigos 01 al 07
double[] costos = new double[100];
char[] estados = new char[100];            // A (Atendida), C (Cancelada), P (Pendiente)
int[] formasPago = new int[3];           // 1 (Efectivo), 2 (Tarjeta), 3 (Seguro)
int[] calificaciones = new int[100];       // 1 al 5 (solo si estado es 'A' "atendido")
string[] comentarios = new string[100];   // (Solo si estado es 'A' "atendido")
string[] registroDePacientes = new string[100]; // Para almacenar el historial de pacientes (nueva hoja)
