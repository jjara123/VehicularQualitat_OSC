﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Infraestrutura.Data.SqlServer
{
    public class General_DAL
    {
        Conexion_DAL cn = new Conexion_DAL();

        //***************************************************************************************************************************************
        //REGISTRO POLIZA *******************************************************************************************************************
        //***************************************************************************************************************************************


        //Listado Tipo Vehiculo
        public List<TipoVehiculoEntity> ListarTipoVehiculo_DAL()
        {
            List<TipoVehiculoEntity> listado = new List<TipoVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoVehiculo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoVehiculoEntity clase = new TipoVehiculoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Uso
        public List<TipoUsoEntity> ListarTipoUso_DAL()
        {
            List<TipoUsoEntity> listado = new List<TipoUsoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoUso", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoUsoEntity clase = new TipoUsoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Marca Automovil
        public List<MarcaVehiculoEntity> ListarMarcaVehiculo_DAL()
        {
            List<MarcaVehiculoEntity> listado = new List<MarcaVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListaMarcaVehiculo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MarcaVehiculoEntity clase = new MarcaVehiculoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Modelo Vehiculo
        public List<ModeloVehiculoEntity> ListarModeloVehiculo_DAL(int id_marca)
        {
            List<ModeloVehiculoEntity> listado = new List<ModeloVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarModelo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_marca", id_marca);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ModeloVehiculoEntity clase = new ModeloVehiculoEntity();
                clase.smidmodelo = int.Parse(dr["smidmodelo"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Documento
        public List<TipoDocumentoEntity> ListarTipoDocumento_DAL()
        {
            List<TipoDocumentoEntity> listado = new List<TipoDocumentoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoDocumento", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoDocumentoEntity clase = new TipoDocumentoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Nacionalidad
        public List<NacionalidadEntity> ListarNacionalidad_DAL()
        {
            List<NacionalidadEntity> listado = new List<NacionalidadEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarNacionalidad", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NacionalidadEntity clase = new NacionalidadEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Sexo
        public List<SexoEntity> ListarSexo_DAL()
        {
            List<SexoEntity> listado = new List<SexoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_Sexo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SexoEntity clase = new SexoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Estado Civil
        public List<EstadoCivilEntity> ListarEstadoCivil_DAL()
        {
            List<EstadoCivilEntity> listado = new List<EstadoCivilEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_EstadoCivil", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EstadoCivilEntity clase = new EstadoCivilEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Departamento
        public List<DepartamentoEntity> ListarDepartamento_DAL()
        {
            List<DepartamentoEntity> listado = new List<DepartamentoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDepartamento", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DepartamentoEntity clase = new DepartamentoEntity();
                clase.vdepartamento = dr["vdepartamento"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Provincia
        public List<ProvinciaEntity> ListarProvincia_DAL(string vdepartamento)
        {
            List<ProvinciaEntity> listado = new List<ProvinciaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarProvincia", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idDepartamento", vdepartamento);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProvinciaEntity clase = new ProvinciaEntity();
                clase.vprovincia = dr["vprovincia"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Distrito
        public List<DistritoEntity> ListarDistrito_DAL(string vdepartamento, string vprovincia)
        {
            List<DistritoEntity> listado = new List<DistritoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDistrito", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idDepartamento", vdepartamento);
            cmd.Parameters.AddWithValue("@idProvincia", vprovincia);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DistritoEntity clase = new DistritoEntity();
                clase.vdistrito = dr["vdistrito"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Tipo Via
        public List<TipoViaEntity> ListarTipoVia()
        {
            List<TipoViaEntity> listado = new List<TipoViaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoVia", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoViaEntity clase = new TipoViaEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Tipo Poliza
        public List<TipoPolizaEntity> ListarTipoPoliza()
        {
            List<TipoPolizaEntity> listado = new List<TipoPolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoPolizaEntity clase = new TipoPolizaEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listar IdPoliza
        public List<IdPolizaEntity> ListarIdPoliza_DAL()
        {
            List<IdPolizaEntity> listado = new List<IdPolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarIdPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                IdPolizaEntity clase = new IdPolizaEntity();
                clase.idpoliza = int.Parse(dr["idpoliza"].ToString());

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listar Forma Pago
        public List<FormaPagoEntity> ListarFormaPago_DAL()
        {
            List<FormaPagoEntity> listado = new List<FormaPagoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarFormaPago", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FormaPagoEntity clase = new FormaPagoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Registar Poliza
        public List<RespuestaPost> RegistrarPoliza_DAL(
            int smidtablatipopoliza,
            string vplaca,
            int smidmodelo,
            int smaniofabrica,
            string vmotor,
            string svin,
            int smnroasiento,
            string vcolor,
            string desumaasegurada,
            int smidtablaclasevehiculo,

            string idnrodocumento,
            string vnombres,
            string vcelular,
            string vtelefono1,
            string vemail,
            string vreferencia,
            string vnumero,
            string vnombrevia,
            int smIdTipoVia,
            int smestadocivil,
            string vdepartamento,
            string vprovincia,
            string vdistrito,
            string dfechanac,
            int btsexo,
            string vapellidopat,
            string vapellidomat,
            int idpoliza,
            string vnomcontacto,
            int sminacionalidad,
            int smidmarca,
            int smidtipodocumento


            )
        {
            List<RespuestaPost> listado = new List<RespuestaPost>();

            SqlCommand cmd = new SqlCommand("SP_VEH_RegistrarPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@smidtablatipopoliza", smidtablatipopoliza);
            cmd.Parameters.AddWithValue("@vplaca", vplaca);
            cmd.Parameters.AddWithValue("@smidmodelo", smidmodelo);
            cmd.Parameters.AddWithValue("@smaniofabrica", smaniofabrica);
            cmd.Parameters.AddWithValue("@vmotor", vmotor);
            cmd.Parameters.AddWithValue("@svin", svin);
            cmd.Parameters.AddWithValue("@smnroasiento", smnroasiento);
            cmd.Parameters.AddWithValue("@vcolor", vcolor);
            cmd.Parameters.AddWithValue("@desumaasegurada", desumaasegurada);
            cmd.Parameters.AddWithValue("@smidtablaclasevehiculo", smidtablaclasevehiculo);

            cmd.Parameters.AddWithValue("@idnrodocumento", idnrodocumento);
            cmd.Parameters.AddWithValue("@vnombres", vnombres);
            cmd.Parameters.AddWithValue("@vcelular", vcelular);
            cmd.Parameters.AddWithValue("@vtelefono1", vtelefono1);
            cmd.Parameters.AddWithValue("@vemail", vemail);
            cmd.Parameters.AddWithValue("@vreferencia", vreferencia);
            cmd.Parameters.AddWithValue("@vnumero", vnumero);
            cmd.Parameters.AddWithValue("@vnombrevia", vnombrevia);
            cmd.Parameters.AddWithValue("@smIdTipoVia", smIdTipoVia);
            cmd.Parameters.AddWithValue("@smestadocivil", smestadocivil);
            cmd.Parameters.AddWithValue("@vdepartamento", vdepartamento);
            cmd.Parameters.AddWithValue("@vprovincia", vprovincia);
            cmd.Parameters.AddWithValue("@vdistrito", vdistrito);
            cmd.Parameters.AddWithValue("@dfechanac", dfechanac);
            cmd.Parameters.AddWithValue("@btsexo", btsexo);
            cmd.Parameters.AddWithValue("@vapellidopat", vapellidopat);
            cmd.Parameters.AddWithValue("@vapellidomat", vapellidomat);
            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);
            cmd.Parameters.AddWithValue("@vnomcontacto", vnomcontacto);
            cmd.Parameters.AddWithValue("@sminacionalidad", sminacionalidad);
            cmd.Parameters.AddWithValue("@smidmarca", smidmarca);
            cmd.Parameters.AddWithValue("@smidtipodocumento", smidtipodocumento);



            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RespuestaPost clase = new RespuestaPost();
                clase.respuesta = dr["respuesta"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //validar persona
        public List<ValidarPersona> ValidarPersona_DAL(string idnrodocumento)
        {
            List<ValidarPersona> listado = new List<ValidarPersona>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ValidarPersona", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idnrodocumento", idnrodocumento);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ValidarPersona clase = new ValidarPersona();
                clase.smidpersona = int.Parse(dr["smidpersona"].ToString());
                clase.sminacionalidad = int.Parse(dr["sminacionalidad"].ToString());
                clase.vnombres = dr["vnombres"].ToString();
                clase.vapellidopat = dr["vapellidopat"].ToString();
                clase.vapellidomat = dr["vapellidomat"].ToString();
                clase.fechanac = dr["fechanac"].ToString();
                clase.btsexo = int.Parse(dr["btsexo"].ToString());
                clase.smestadocivil = int.Parse(dr["smestadocivil"].ToString());
                clase.vtelefono1 = dr["vtelefono1"].ToString();
                clase.vcelular = dr["vcelular"].ToString();
                clase.vemail = dr["vemail"].ToString();
                clase.vubigeo = dr["vubigeo"].ToString();
                clase.smIdTipoVia = int.Parse(dr["smIdTipoVia"].ToString());
                clase.vnumero = dr["vnumero"].ToString();
                clase.vreferencia = dr["vreferencia"].ToString();
                clase.vnombrevia = dr["vnombrevia"].ToString();
                clase.Departamento = dr["Departamento"].ToString();
                clase.Provincia = dr["Provincia"].ToString();
                clase.Distrito = dr["Distrito"].ToString();
                clase.smidtipodocumento = int.Parse(dr["smidtipodocumento"].ToString());
                clase.vnomcontacto = dr["vnomcontacto"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listar Poliza

        public List<ListarPolizaEntity> ListarPoliza_DAL(string idpoliza, string placa, string fechaini, string fechafin, string nombre, int NroDePagina, int RegPorPag)
        {
            List<ListarPolizaEntity> listado = new List<ListarPolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@fechaini", fechaini);
            cmd.Parameters.AddWithValue("@fechafin", fechafin);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@NroDePagina", NroDePagina);
            cmd.Parameters.AddWithValue("@RegPorPag", RegPorPag);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListarPolizaEntity clase = new ListarPolizaEntity();
                clase.idpoliza = dr["idpoliza"].ToString();
                clase.Persona = dr["Persona"].ToString();
                clase.vplaca = dr["vplaca"].ToString();
                clase.Marca = dr["Marca"].ToString();
                clase.Emision = dr["Emision"].ToString();
                clase.Estado = dr["Estado"].ToString();
                clase.TotalRegistros = dr["TotalRegistros"].ToString();
                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //validar Poliza

        public List<ValidarIdPoliza> ValidarIdPoliza_DAL(int idpoliza)
        {
            List<ValidarIdPoliza> respuesta = new List<ValidarIdPoliza>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ValidarIdPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ValidarIdPoliza clase = new ValidarIdPoliza();
                clase.respuesta = dr["respuesta"].ToString();


                respuesta.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return respuesta;
        }



        //***************************************************************************************************************************************
        //Registro Inspeccion *******************************************************************************************************************
        //***************************************************************************************************************************************



        //Listado Datos Poliza
        public List<DatosPolizaEntity> ListarDatosPoliza_DAL(int idpolizap)
        {
            List<DatosPolizaEntity> listado = new List<DatosPolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDatosPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idpoliza", idpolizap);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DatosPolizaEntity clase = new DatosPolizaEntity();
                clase.smidpersona = int.Parse(dr["smidpersona"].ToString());
                clase.idpoliza = int.Parse(dr["idpoliza"].ToString());
                clase.idvehiculo = int.Parse(dr["idvehiculo"].ToString());

                clase.tipocontratante = dr["tipocontratante"].ToString();
                clase.tipodoc = dr["tipodoc"].ToString();
                clase.dni = dr["dni"].ToString();
                clase.nombre = dr["nombre"].ToString();
                clase.sexo = int.Parse(dr["sexo"].ToString());
                clase.nacionalidad = dr["nacionalidad"].ToString();
                clase.ecivil = int.Parse(dr["ecivil"].ToString());
                clase.fecnaci = dr["fecnaci"].ToString();
                clase.email = dr["email"].ToString();
                clase.telf = dr["telf"].ToString();
                clase.celu = dr["celu"].ToString();

                clase.nropoliza = int.Parse(dr["nropoliza"].ToString());
                clase.planproducto = dr["planproducto"].ToString();
                clase.vigencia = dr["vigencia"].ToString();
                clase.tipopoliza = dr["tipopoliza"].ToString();
                clase.formapago = int.Parse(dr["formapago"].ToString());

                clase.claseveh = int.Parse(dr["claseveh"].ToString());
                clase.marcaveh = dr["marcaveh"].ToString();
                clase.modeloveh = dr["modeloveh"].ToString();
                clase.anio = dr["anio"].ToString();
                clase.color = dr["color"].ToString();
                clase.nromotor = dr["nromotor"].ToString();
                clase.placa = dr["placa"].ToString();
                clase.vin = dr["vin"].ToString();
                clase.puertas = dr["puertas"].ToString();
                clase.nroserie = dr["nroserie"].ToString();
                clase.ikilometraje = int.Parse(dr["ikilometraje"].ToString());

                clase.fecrecordatorio = dr["fecrecordatorio"].ToString();
                clase.horrecordatorio = dr["horrecordatorio"].ToString();
                clase.fecinspeccion = dr["fecinspeccion"].ToString();
                clase.hrinspeccion = dr["hrinspeccion"].ToString();
                clase.estado = dr["estado"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Combustible
        public List<TipoCombustibleEntity> ListarTipoCombustible_DAL()
        {
            List<TipoCombustibleEntity> listado = new List<TipoCombustibleEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarTipoCombustible", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoCombustibleEntity clase = new TipoCombustibleEntity();
                
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();               

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Carroceria
        public List<TipoCarroceriaEntity> ListarTipoCarroceria_DAL()
        {
            List<TipoCarroceriaEntity> listado = new List<TipoCarroceriaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarTipoCarroceria", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoCarroceriaEntity clase = new TipoCarroceriaEntity();

                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listar Estado Inspeccion

        public List<EstadoInspeccionEntity> ListarEstadoInspeccion_DAL()
        {
            List<EstadoInspeccionEntity> listado = new List<EstadoInspeccionEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarEstadoInspeccion", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EstadoInspeccionEntity clase = new EstadoInspeccionEntity();              
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();                

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Transmision
        public List<TipoTransmisionEntity> ListarTipoTransmision_DAL()
        {
            List<TipoTransmisionEntity> listado = new List<TipoTransmisionEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarTipoTransmision", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoTransmisionEntity clase = new TipoTransmisionEntity();

                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Clase Rodante
        public List<ClaseRodanteEntity> ListarClaseRodante_DAL()
        {
            List<ClaseRodanteEntity> listado = new List<ClaseRodanteEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarClaseRodante", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ClaseRodanteEntity clase = new ClaseRodanteEntity();

                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Daño
        public List<TipoDanoEntity> ListarTipoDano_DAL()
        {
            List<TipoDanoEntity> listado = new List<TipoDanoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarTipoDano", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoDanoEntity clase = new TipoDanoEntity();

                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Registro de Inspeccion
        public List<RespuestaPost> RegistrarInspeccion_DAL(int smidpersona,int idpoliza, int idvehiculo, int sminacionalidad,
            int smestadocivil, string dfechanac, string vemail, string vtelefono1, string vcelular, int btsexo, int smidtablaformapago,
            int smidtipovehiculo, int smidmarca, int smidmodelo, int smianiofabricacion, string vcolor, int smidtipotransmision,
            int smidclaserodante, int smidtipocombustible, int inroasiento, int smidcarroceria, string vnromotor, string vplaca,
            string vnroserie, int ikilometraje, string vVin,
            int iidinspeccion, string fecInspeccion, string hrInspeccion, string fecRecordatorio, string hrRecordatorio, 
            int smidtablaestadoinspeccion,
            int btaire, int btalarma, int btpestillos, int bttapizcuero, int btlunaselectricas, int btseguroruedas,
            int btllantarep, int btequipomusicaorig, int btparlantesoriginal, int btaccesorios, string vobservacionesaccesorios,
            int smidtablatipodano, string vobservaciones,
            int smidestadofarodelante, int smcantfarodelante, int smidestadofaropost, int smcantfaropost,
            int smestadofarodireccion, int smcantfarodireccion, int smcantfaroneblinero, int smestadofaroneblinero,
            int smcantespejoexterno, int smestadoespejoexterno, int smestadospoiler, int smcantspoiler, int smtipoaros,
            int smcantaros, int smestadomascara, int smpintura, int smtipoparachoque, int smcarroceria, int smconsola,
            int smtablero, int btequipomusicafijo, string vinspector)
        {
            List<RespuestaPost> listado = new List<RespuestaPost>();

            SqlCommand cmd = new SqlCommand("SP_VEH_RegistrarInspeccion", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@smidpersona", smidpersona);
            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);
            cmd.Parameters.AddWithValue("@idvehiculo", idvehiculo);
            cmd.Parameters.AddWithValue("@sminacionalidad", sminacionalidad);
            cmd.Parameters.AddWithValue("@smestadocivil", smestadocivil);
            cmd.Parameters.AddWithValue("@dfechanac", dfechanac);
            cmd.Parameters.AddWithValue("@vemail", vemail);
            cmd.Parameters.AddWithValue("@vtelefono1", vtelefono1);
            cmd.Parameters.AddWithValue("@vcelular", vcelular);
            cmd.Parameters.AddWithValue("@btsexo", btsexo);

            cmd.Parameters.AddWithValue("@smidtablaformapago", smidtablaformapago);

            cmd.Parameters.AddWithValue("@smidtipovehiculo", smidtipovehiculo);
            cmd.Parameters.AddWithValue("@smidmarca", smidmarca);
            cmd.Parameters.AddWithValue("@smidmodelo", smidmodelo);
            cmd.Parameters.AddWithValue("@smianiofabricacion", smianiofabricacion);
            cmd.Parameters.AddWithValue("@vcolor", vcolor);
            cmd.Parameters.AddWithValue("@smidtipotransmision", smidtipotransmision);
            cmd.Parameters.AddWithValue("@smidclaserodante", smidclaserodante);
            cmd.Parameters.AddWithValue("@smidtipocombustible", smidtipocombustible);
            cmd.Parameters.AddWithValue("@inroasiento", inroasiento);
            cmd.Parameters.AddWithValue("@smidcarroceria", smidcarroceria);
            cmd.Parameters.AddWithValue("@vnromotor", vnromotor);
            cmd.Parameters.AddWithValue("@vplaca", vplaca);
            cmd.Parameters.AddWithValue("@vnroserie", vnroserie);
            cmd.Parameters.AddWithValue("@ikilometraje", ikilometraje);
            cmd.Parameters.AddWithValue("@vVin", vVin);

            cmd.Parameters.AddWithValue("@iidinspeccion", iidinspeccion);
            cmd.Parameters.AddWithValue("@fecInspeccion", fecInspeccion);
            cmd.Parameters.AddWithValue("@hrInspeccion", hrInspeccion);
            cmd.Parameters.AddWithValue("@fecRecordatorio", fecRecordatorio);
            cmd.Parameters.AddWithValue("@hrRecordatorio", hrRecordatorio);
            cmd.Parameters.AddWithValue("@smidtablaestadoinspeccion", smidtablaestadoinspeccion);

            cmd.Parameters.AddWithValue("@btaire", btaire);
            cmd.Parameters.AddWithValue("@btalarma", btalarma);
            cmd.Parameters.AddWithValue("@btpestillos", btpestillos);
            cmd.Parameters.AddWithValue("@bttapizcuero", bttapizcuero);
            cmd.Parameters.AddWithValue("@btlunaselectricas", btlunaselectricas);
            cmd.Parameters.AddWithValue("@btseguroruedas", btseguroruedas);
            cmd.Parameters.AddWithValue("@btllantarep", btllantarep);
            cmd.Parameters.AddWithValue("@btequipomusicaorig", btequipomusicaorig);
            cmd.Parameters.AddWithValue("@btparlantesoriginal", btparlantesoriginal);
            cmd.Parameters.AddWithValue("@btaccesorios", btaccesorios);
            cmd.Parameters.AddWithValue("@vobservacionesaccesorios", vobservacionesaccesorios);
            cmd.Parameters.AddWithValue("@smidtablatipodano", smidtablatipodano);
            cmd.Parameters.AddWithValue("@vobservaciones", vobservaciones);

            cmd.Parameters.AddWithValue("@smidestadofarodelante", smidestadofarodelante);
            cmd.Parameters.AddWithValue("@smcantfarodelante", smcantfarodelante);
            cmd.Parameters.AddWithValue("@smidestadofaropost", smidestadofaropost);
            cmd.Parameters.AddWithValue("@smcantfaropost", smcantfaropost);
            cmd.Parameters.AddWithValue("@smestadofarodireccion", smestadofarodireccion);
            cmd.Parameters.AddWithValue("@smcantfarodireccion", smcantfarodireccion);
            cmd.Parameters.AddWithValue("@smcantfaroneblinero", smcantfaroneblinero);
            cmd.Parameters.AddWithValue("@smestadofaroneblinero", smestadofaroneblinero);
            cmd.Parameters.AddWithValue("@smcantespejoexterno", smcantespejoexterno);
            cmd.Parameters.AddWithValue("@smestadoespejoexterno", smestadoespejoexterno);
            cmd.Parameters.AddWithValue("@smestadospoiler", smestadospoiler);
            cmd.Parameters.AddWithValue("@smcantspoiler", smcantspoiler);
            cmd.Parameters.AddWithValue("@smtipoaros", smtipoaros);
            cmd.Parameters.AddWithValue("@smcantaros", smcantaros);
            cmd.Parameters.AddWithValue("@smestadomascara", smestadomascara);
            cmd.Parameters.AddWithValue("@smpintura", smpintura);
            cmd.Parameters.AddWithValue("@smtipoparachoque", smtipoparachoque);
            cmd.Parameters.AddWithValue("@smcarroceria", smcarroceria);
            cmd.Parameters.AddWithValue("@smconsola", smconsola);
            cmd.Parameters.AddWithValue("@smtablero", smtablero);
            cmd.Parameters.AddWithValue("@btequipomusicafijo", btequipomusicafijo);
            cmd.Parameters.AddWithValue("@vinspector", vinspector);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RespuestaPost clase = new RespuestaPost();
              
                clase.respuesta = dr["respuesta"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }


        //Listado Imagenes Inpeccion
        public List<ImagenInspeccionEntity> ListarImgInspeccion_DAL(int codinspeccion)
        {
            List<ImagenInspeccionEntity> listado = new List<ImagenInspeccionEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarImgInspeccion", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codinspeccion", codinspeccion);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ImagenInspeccionEntity clase = new ImagenInspeccionEntity();
                clase.idimagen = int.Parse(dr["idimagen"].ToString());
                clase.descripcion = dr["descripcion"].ToString();
                clase.hora = dr["hora"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Datos Poliza
        public List<Inspeccion> ListarInspeccion_DAL(string iidinspeccion,string idpoliza, string placa, string fechaini, string fechafin, string nombre, int NroDePagina, int RegPorPag)
        {
            List<Inspeccion> listado = new List<Inspeccion>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarInspeccion", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@iidinspeccion", iidinspeccion);
            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@fechaini", fechaini);
            cmd.Parameters.AddWithValue("@fechafin", fechafin);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@NroDePagina", NroDePagina);
            cmd.Parameters.AddWithValue("@RegPorPag", RegPorPag);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Inspeccion clase = new Inspeccion();
                clase.iidinspeccion = dr["iidinspeccion"].ToString();
                clase.idpoliza = dr["idpoliza"].ToString();
                clase.Persona = dr["Persona"].ToString();
                clase.dtfec_hora_registro = dr["dtfec_hora_registro"].ToString();
                clase.vplaca = dr["vplaca"].ToString();
                //clase.smidtablaestadoinspeccion = dr["smidtablaestadoinspeccion"].ToString();
                clase.dfecha = dr["dfecha"].ToString();
                clase.Marca = dr["Marca"].ToString();
                clase.Modelo = dr["Modelo"].ToString();
                clase.Estado = dr["Estado"].ToString();
                clase.TotalRegistros = dr["TotalRegistros"].ToString();                
                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //detalle poliza
        public List<ReportePolizaEntity> ReportePoliza_DAL(int idpoliza)
        {
            List<ReportePolizaEntity> listado = new List<ReportePolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDetaPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idpoliza", idpoliza);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReportePolizaEntity clase = new ReportePolizaEntity();
                clase.smidpersona = int.Parse(dr["smidpersona"].ToString());
                clase.idpoliza = int.Parse(dr["idpoliza"].ToString());
                clase.idvehiculo = int.Parse(dr["idvehiculo"].ToString());
                clase.claseveh = int.Parse(dr["smidpersona"].ToString());
                clase.marcaveh = int.Parse(dr["marcaveh"].ToString());
                clase.modeloveh = int.Parse(dr["modeloveh"].ToString());
                clase.anio = int.Parse(dr["anio"].ToString());
                clase.color = dr["color"].ToString();
                clase.nromotor = dr["nromotor"].ToString();
                clase.placa = dr["placa"].ToString();
                clase.vin = dr["vin"].ToString();
                clase.puertas = int.Parse(dr["puertas"].ToString());
                clase.uso = int.Parse(dr["uso"].ToString());
                clase.suma = dr["suma"].ToString();
                clase.nacionalidad = int.Parse(dr["nacionalidad"].ToString());
                clase.nombre = dr["nombre"].ToString();
                clase.apepaterno = dr["apepaterno"].ToString();
                clase.apematerno = dr["apematerno"].ToString();
                clase.nacimiento = dr["nacimiento"].ToString();
                clase.genero = int.Parse(dr["genero"].ToString());
                clase.estadocivil = int.Parse(dr["estadocivil"].ToString());
                clase.telefono = dr["telefono"].ToString();
                clase.celular = dr["celular"].ToString();
                clase.mail = dr["mail"].ToString();
                clase.ubigeo = int.Parse(dr["ubigeo"].ToString());
                clase.via = int.Parse(dr["via"].ToString());
                clase.numero = dr["numero"].ToString();
                clase.referencia = dr["referencia"].ToString();
                clase.nomvia = dr["nomvia"].ToString();
                clase.tipdocumento = int.Parse(dr["tipdocumento"].ToString());
                clase.nrodocumento = dr["nrodocumento"].ToString();
                clase.contacto = dr["contacto"].ToString();
                clase.Departamento = dr["Departamento"].ToString();
                clase.Provincia = dr["Provincia"].ToString();
                clase.Distrito = dr["Distrito"].ToString();
                clase.inivigencia = dr["inivigencia"].ToString();
                clase.finvigencia = dr["finvigencia"].ToString();
                clase.tippoliza = int.Parse(dr["tippoliza"].ToString());
                clase.planproducto = dr["planproducto"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //***************************************************************************************************************************************
        //Reporte Inspeccion *******************************************************************************************************************
        //***************************************************************************************************************************************

        //Listado Modelo Vehiculo
        public List<ReporteInspeccionEntity> ListarReporteInspeccion_DAL(int iidinspeccion)
        {
            List<ReporteInspeccionEntity> listado = new List<ReporteInspeccionEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ReporteInspeccion", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@iidinspeccion", iidinspeccion);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReporteInspeccionEntity clase = new ReporteInspeccionEntity();                
                clase.nombre = dr["nombre"].ToString();
                clase.nrodoc = dr["nrodoc"].ToString();
                clase.celular = dr["celular"].ToString();

                clase.fecha = dr["fecha"].ToString();
                clase.hora = dr["hora"].ToString();

                clase.placa = dr["placa"].ToString();
                clase.marca = dr["marca"].ToString();
                clase.modelo = dr["modelo"].ToString();
                clase.color = dr["color"].ToString();
                clase.nroserie = dr["nroserie"].ToString();
                clase.nrovin = dr["nrovin"].ToString();
                clase.kilometraje = int.Parse(dr["kilometraje"].ToString());

                clase.btaire = dr["btaire"].ToString();
                clase.btlunaselectricas = dr["btlunaselectricas"].ToString();
                clase.btalarma = dr["btalarma"].ToString();
                clase.btseguroruedas = dr["btseguroruedas"].ToString();
                clase.btpestillos = dr["btpestillos"].ToString();
                clase.btllantarep = dr["btllantarep"].ToString();
                clase.bttapizcuero = dr["bttapizcuero"].ToString();
                clase.observaciones = dr["observaciones"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }





















    }
}
