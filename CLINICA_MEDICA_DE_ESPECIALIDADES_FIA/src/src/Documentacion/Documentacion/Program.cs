// Arreglos de las clases para guardar los  datos de las citas médicas

string[] nombresPacientes = new string[100];
string[] codigosCitas = new string[100];    // Formato C-000X
string[] nombresMedicos = new string[100];
string[] fechasCitas = new string[100];     // DD/MM/AAAA
int[] edades = new int[100];
int[] especialidades = new int[100];       // Códigos 01 al 07
double[] costos = new double[100];
char[] estados = new char[100];            // A (Atendida), C (Cancelada), P (Pendiente)
int[] formasPago = new int[100];           // 1 (Efectivo), 2 (Tarjeta), 3 (Seguro)
int[] calificaciones = new int[100];       // 1 al 5 (solo si estado es 'A')
