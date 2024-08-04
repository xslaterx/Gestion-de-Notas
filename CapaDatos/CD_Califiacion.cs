﻿using System.Data;
using BDGestion;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;

namespace CapaDatos;

public class CD_Califiacion
{
    private readonly IDbConnection _db;

    public CD_Califiacion()
    {
        _db = new SqliteConnection(Conexion.cadena);
        _db.Open();
    }

    public List<Calificacion> Listar()
    {
        string query =
            "SELECT * FROM Calificaciones ";
        var calificaciones = _db.Query<Calificacion>(query);
        _db.Close();
        return calificaciones.ToList();
    }

    public List<Calificacion> ListarPorEstudianteId(int id)
    {
        string query =
            "SELECT * FROM Calificaciones WHERE EstudianteId = @id";
        var calificaciones = _db.Query<Calificacion>(query, new { id });
        _db.Close();
        return calificaciones.ToList();
    }

    public int Registrar(Calificacion obj, out string mensaje)
    {
        int calificacionesGeneradas = 0;
        mensaje = string.Empty;
        try
        {
            string query =
                "INSERT INTO Calificaciones(CalificacionId,EstudianteId,CursoId,Nota,PrimerP,SegundoP,TercerP,CuartoP,ExamenF,AcumuladoC,AcumuladoEX,ExamenEx,PuntuacionF) "
            + "VALUES (@CalificacionId,@EstudianteId,@CursoId,@Nota,@PrimerP,@SegundoP,@TercerP,@CuartoP,@ExamenF,@AcumuladoC,@AcumuladoEX,@ExamenEx,@PuntuacionF)";
            calificacionesGeneradas = _db.Execute(query,obj);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            mensaje = e.ToString();
        }

        _db.Close();
        return calificacionesGeneradas;
    }

    public bool Editar(Calificacion obj , out string mensaje)
    {
        bool respuesta = false;
        mensaje = string.Empty;
        try
        {
            string query =
                "UPDATE Calificaciones SET EstudianteId = @EstudianteId, CursoId = @CursoId, Nota = @Nota, PrimerP = @PrimerP, SegundoP = @SegundoP, TercerP = @TercerP, CuartoP = @CuartoP, ExamenF = @ExamenF, AcumuladoC = @AcumuladoC, AcumuladoEX = @AcumuladoEX, ExamenEx = @ExamenEx, PuntuacionF = @PuntuacionF WHERE CalificacionId = @CalificacionId";
            respuesta = _db.Execute(query, obj) > 0;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            mensaje = e.ToString();
        }
        _db.Close();
        return respuesta;
        
    }
}