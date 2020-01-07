using Microsoft.EntityFrameworkCore;

namespace apisii.Models {

    public class ApiSiiContext: DbContext {

        public ApiSiiContext( DbContextOptions<ApiSiiContext> options )
            : base(options) {

            }

            public DbSet<Empresa> Empresa { get; set; }


    }


}