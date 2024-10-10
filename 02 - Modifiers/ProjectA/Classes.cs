 

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Só quem esta herdando, pode utilizar o metodo.

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Apenas o propria .dll pode utilizar

// Access is limited to the current assembly.
/*******************************************************/
// protected internal:

// tem que ser uma heranca e estar na mesma .dll(assembly) 

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// somente para aquele tipo

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// tem que ser uma heranca e estar na mesma .dll(assembly)

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/

//[assembly: InternalsVisibleTo("ProjectB")]
namespace ProjectA
{
    #region Classes

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    //sealed(selada) ela nao pode ser herdada, somente instanciada. 
    public sealed class Selada { }

    class Privada { }

    internal class Interna { }

    abstract class Abstrata { }

    #endregion
    
    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion
}


