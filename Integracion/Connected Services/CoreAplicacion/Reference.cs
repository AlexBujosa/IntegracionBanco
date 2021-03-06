//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integracion.CoreAplicacion {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CoreAplicacion.somee.com", ConfigurationName="CoreAplicacion.CoreSoap")]
    public interface CoreSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/Autenticacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Autenticacion(string usuario, string contraseña, int pin, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/Autenticacion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> AutenticacionAsync(string usuario, string contraseña, int pin, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/Transaccion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/Transaccion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> TransaccionAsync(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/ObtenerTodasCuentasDiferentes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/ObtenerTodasCuentasDiferentes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerTodasCuentasDiferentesAsync(int ID_Cliente, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/TransaccionATercero", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/TransaccionATercero", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> TransaccionATerceroAsync(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/InsertarBeneficiario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool InsertarBeneficiario(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CoreAplicacion.somee.com/InsertarBeneficiario", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> InsertarBeneficiarioAsync(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CoreSoapChannel : Integracion.CoreAplicacion.CoreSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoreSoapClient : System.ServiceModel.ClientBase<Integracion.CoreAplicacion.CoreSoap>, Integracion.CoreAplicacion.CoreSoap {
        
        public CoreSoapClient() {
        }
        
        public CoreSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoreSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoreSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoreSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Autenticacion(string usuario, string contraseña, int pin, string clave) {
            return base.Channel.Autenticacion(usuario, contraseña, pin, clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> AutenticacionAsync(string usuario, string contraseña, int pin, string clave) {
            return base.Channel.AutenticacionAsync(usuario, contraseña, pin, clave);
        }
        
        public System.Data.DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave) {
            return base.Channel.Transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto, clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> TransaccionAsync(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave) {
            return base.Channel.TransaccionAsync(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto, clave);
        }
        
        public System.Data.DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente, string clave) {
            return base.Channel.ObtenerTodasCuentasDiferentes(ID_Cliente, clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerTodasCuentasDiferentesAsync(int ID_Cliente, string clave) {
            return base.Channel.ObtenerTodasCuentasDiferentesAsync(ID_Cliente, clave);
        }
        
        public System.Data.DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave) {
            return base.Channel.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> TransaccionATerceroAsync(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave) {
            return base.Channel.TransaccionATerceroAsync(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, clave);
        }
        
        public bool InsertarBeneficiario(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave) {
            return base.Channel.InsertarBeneficiario(NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, clave);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarBeneficiarioAsync(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave) {
            return base.Channel.InsertarBeneficiarioAsync(NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, clave);
        }
    }
}
