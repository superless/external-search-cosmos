using trifenix.connect.input;
using trifenix.connect.interfaces.db;
using trifenix.connect.interfaces.graph;
using trifenix.connect.model;

namespace trifenix.connect.interfaces.external
{
    /// <summary>
    /// Elementos necesarios para operaciones crud en base de datos.
    /// Las operaciones son dependientes de cosmos db
    /// debido principalmente a la manera que usa IQueryable cosmonaut.
    /// </summary>
    public interface IDbConnect {


        /// <summary>
        /// Elemento principal de base de datos
        /// </summary>
        /// <typeparam name="T">elemento de base de datos de persistencia</typeparam>
        /// <returns>Reposirio de base de datos para tipo T</returns>
        IMainGenericDb<T> GetMainDb<T>() where T : DocumentDb;

       

        /// <summary>
        /// Api de identidades de Microsoft.
        /// </summary>
        IGraphApi GraphApi { get; }


        // Validaciones de input, usando los atributos del modelo.
        IValidatorAttributes<T_INPUT> GetValidator<T_INPUT, T_DB>() where T_INPUT : InputBase where T_DB : DocumentDb;

        


    }

}