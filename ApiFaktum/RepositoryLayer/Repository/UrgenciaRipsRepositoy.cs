﻿using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class UrgenciaRipsRepositoy : IUrgenciaRipsRepository
    {
        private readonly ApplicationDbContext objContext;
        private readonly IMapper mapper;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <param name="_mapper"></param>
        /// <returns></returns>
        public UrgenciaRipsRepositoy(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los usuarios de los rips
        /// </summary>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUrgenciaRips()
        {
            Result oRespuesta = new Result();
            List<UrgenciaRips>? lstResult = new List<UrgenciaRips>();

            try
            {
                lstResult =
                    await objContext.UrgenciaRips.ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<UrgenciaRips>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<UrgenciaRips>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearUrgenciaRips(UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new();
            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<UrgenciaRips>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegGuardado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarUrgenciaRips(UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<UrgenciaRips>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegActualizado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarUrgenciaRips(UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.UrgenciaRips.Remove(mapper.Map<UrgenciaRips>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegEliminado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }
    }
}