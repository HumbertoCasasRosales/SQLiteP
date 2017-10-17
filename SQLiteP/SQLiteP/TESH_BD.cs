using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteP
{
    public class TESH_BD
    {
        int id;
        string nombres;
        string apellidos;
        string direccion;
        int telefono;
        string carrera;
        int semestre;
        string correo;
        string git;

        [PrimaryKey, MaxLength(8), Unique]
        public int Matricula
        {
            get { return id; }
            set { id = value; }
        }

        [MaxLength(50)]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        [MaxLength(50)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        [MaxLength(50)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [MaxLength(12)]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        [MaxLength(40)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        [MaxLength(3)]
        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [MaxLength(45)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [MaxLength(45)]
        public string Git
        {
            get { return git; }
            set { git = value; }
        }
    }
}
