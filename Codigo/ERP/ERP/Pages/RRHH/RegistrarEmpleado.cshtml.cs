using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Pages.RRHH
{
    public class RegistrarEmpleadoModel : PageModel
    {
        [BindProperty]
        public string primerNombre { get; set; } = "";

        public string segundoNombre { get; set; } = "";

        [BindProperty]
        public string primerApellido { get; set; } = "";

        [BindProperty]
        public string segundoApellido { get; set; } = "";

        public List<string> provincias { get; set; }

        public List<string> cantonesSanJose { get; set; }
        public List<string> cantonesAlajuela { get; set; }
        public List<string> cantonesCartago { get; set; }
        public List<string> cantonesHeredia { get; set; }
        public List<string> cantonesGuanacaste { get; set; }
        public List<string> cantonesPuntarenas { get; set; }
        public List<string> cantonesLimon { get; set; }

        // Distritos de San Jos�
        public List<string> distritosGoicoechea { get; set; }
        public List<string> distritosSanJose { get; set; }
        public List<string> distritosEscazu { get; set; }
        public List<string> distritosDesamparados { get; set; }
        public List<string> distritosPuriscal { get; set; }
        public List<string> distritosTibas { get; set; }
        public List<string> distritosMoravia { get; set; }
        public List<string> distritosSantaAna { get; set; }
        public List<string> distritosAlajuelita { get; set; }
        public List<string> distritosVazquezDeCoronado { get; set; }
        public List<string> distritosAcosta { get; set; }
        public List<string> distritosTurrubares { get; set; }
        public List<string> distritosDota { get; set; }
        public List<string> distritosCurridabat { get; set; }


        // Distritos de Alajuela
        public List<string> distritosAlajuela { get; set; }
        public List<string> distritosSanRamon { get; set; }
        public List<string> distritosGrecia { get; set; }
        public List<string> distritosSanMateo { get; set; }
        public List<string> distritosAtenas { get; set; }
        public List<string> distritosNaranjo { get; set; }
        public List<string> distritosPalmares { get; set; }
        public List<string> distritosPoas { get; set; }
        public List<string> distritosOrotina { get; set; }
        public List<string> distritosSanCarlos { get; set; }
        public List<string> distritosZarcero { get; set; }

        public List<string> distritosSarch� { get; set; }
        public List<string> distritosUpala { get; set; }
        public List<string> distritosLosChiles { get; set; }
        public List<string> distritosGuatuso { get; set; }
        public List<string> distritosRioCuarto { get; set; }

        // Distritos de Cartago
        public List<string> distritosCartago { get; set; }
        public List<string> distritosPara�so { get; set; }
        public List<string> distritosLaUnion { get; set; }
        public List<string> distritosJimenez { get; set; }
        public List<string> distritosTurrialba { get; set; }
        public List<string> distritosAlvarado { get; set; }
        public List<string> distritosOreamuno { get; set; }
        public List<string> distritosElGuarco { get; set; }


        // Distritos de Heredia
        public List<string> distritosHeredia { get; set; }
        public List<string> distritosBarva { get; set; }
        public List<string> distritosSantoDomingo { get; set; }
        public List<string> distritosSantaBarbara { get; set; }
        public List<string> distritosSanRafael { get; set; }
        public List<string> distritosSanIsidro { get; set; }
        public List<string> distritosBelen { get; set; }
        public List<string> distritosFlores { get; set; }
        public List<string> distritosSanPablo { get; set; }
        public List<string> distritosSarapiqui { get; set; }

        // Distritos de Guanacaste
        private List<string> distritosLiberia;
        private List<string> distritosNicoya;
        private List<string> distritosSantaCruz;
        private List<string> distritosBagaces;
        private List<string> distritosCarrillo;
        private List<string> distritosCa�as;
        private List<string> distritosAbangares;
        private List<string> distritosTilar�n;
        private List<string> distritosNandayure;
        private List<string> distritosLaCruz;
        private List<string> distritosHojancha;

        //Distritos de Puntarenas
        private List<string> distritosPuntarenas;
        private List<string> distritosEsparza;
        private List<string> distritosBuenosAires;
        private List<string> distritosMontesDeOro;
        private List<string> distritosOsa;
        private List<string> distritosQuepos;
        private List<string> distritosGolfito;
        private List<string> distritosCotoBrus;
        private List<string> distritosParrita;
        private List<string> distritosCorredores;
        private List<string> distritosGarabito;

        //Distritos de Lim�n
        private List<string> distritosLim�n;
        private List<string> distritosPococ�;
        private List<string> distritosSiquirres;
        private List<string> distritosTalamanca;
        private List<string> distritosMatina;
        private List<string> distritosGu�cimo;
        public void OnGet()
        {
            //Lista de provincias
            provincias = new List<string>();
            provincias.Add("San Jos�");
            provincias.Add("Alajuela");
            provincias.Add("Cartago");
            provincias.Add("Heredia");
            provincias.Add("Guanacaste");
            provincias.Add("Puntarenas");
            provincias.Add("Lim�n");

            //Cantones de San Jos�
            cantonesSanJose = new List<string>
        {
            "San Jos�", "Escaz�", "Desamparados", "Puriscal","Tarraz�", "Aserr�", "Mora", "Goicoechea", "Santa Ana", "Alajuelita", "V�zquez de Coronado",
    "Acosta", "Tib�s", "Moravia", "Montes de Oca", "Turrubares", "Dota", "Curridabat", "P�rez Zeled�n", "Le�n Cort�s Castro"
        };


            //Cantones de Alajuela
            cantonesAlajuela = new List<string>
        {
            "Alajuela", "San Ram�n", "Grecia", "San Mateo", "Atenas", "Naranjo", "Palmares",
             "Po�s", "Orotina", "San Carlos", "Zarcero", "Sarch�","Upala", "Los Chiles", "Guatuso", "R�o Cuarto"
        };

            //Cantones de Cartago
            cantonesCartago = new List<string>
        {
            "Cartago", "Para�so", "La Uni�n", "Jim�nez", "Turrialba", "Alvarado",
            "Oreamuno", "El Guarco"
        };

            // Cantones de Heredia
            cantonesHeredia = new List<string>
        {
             "Heredia", "Barva", "Santo Domingo", "San Rafael",
            "San Isidro", "Bel�n", "Flores", "San Pablo", "Sarapiqu�"
        };

            // Cantones de Guanacaste
            cantonesGuanacaste = new List<string>
        {
            "Liberia", "Nicoya", "Santa Cruz", "Bagaces", "Carrillo", "Ca�as",
            "Abangares", "Tilar�n", "Nandayure", "La Cruz", "Hojancha"
        };

            // Cantones de Puntarenas
            cantonesPuntarenas = new List<string>
        {
            "Puntarenas", "Esparza", "Buenos Aires", "Montes de Oro", "Osa",
            "Quepos", "Golfito", "Coto Brus", "Parrita", "Corredores", "Garabito"
        };

            // Cantones de Lim�n
            cantonesLimon = new List<string>
        {
            "Lim�n", "Pococ�", "Siquirres", "Talamanca", "Matina", "Gu�cimo"
        };

            // Distritos de cada cant�n en la provincia de San Jos�
            // Listas de distritos por cant�n
            List<string> distritosSanJose = new List<string>
         {
                "Carmen", "Merced", "Hospital", "Catedral", "Zapote",
                "San Francisco de Dos R�os", "La Uruca", "Mata Redonda",
                "Pavas", "Hatillo", "San Sebasti�n"
        };

            List<string> distritosEscazu = new List<string>
        {
                "Escaz�", "San Antonio", "San Rafael"
        };

            List<string> distritosDesamparados = new List<string>
        {
                "Desamparados", "San Miguel", "San Juan de Dios",
                "San Rafael Arriba", "San Antonio", "Frailes",
                "Patarr�", "San Crist�bal", "Rosario", "Damas",
                "San Rafael Abajo", "Gravilias", "Los Guido"
        };

            List<string> distritosPuriscal = new List<string>
        {
                "Santiago", "Mercedes Sur", "Barbacoas",
                "Grifo Alto", "San Rafael", "Candelarita",
                "Desamparaditos", "San Antonio", "Chires"
        };

            List<string> distritosTarraz� = new List<string>
        {
                "San Marcos", "San Lorenzo", "San Carlos"
        };

            List<string> distritosAserri = new List<string>
        {
                "Aserr�", "Tarbaca", "Vuelta de Jorco",
                "San Gabriel", "Legua", "Monterrey", "Salitrillos"
        };

            List<string> distritosMora = new List<string>
        {
               "Col�n", "Guayabo", "Tabarcia",
                "Piedras Negras", "Picagres", "Jaris", "Quitirris�"
        };

            List<string> distritosGoicoechea = new List<string>
        {
                "Guadalupe", "San Francisco", "Calle Blancos",
                "Mata de Pl�tano", "Ip�s", "Rancho Redondo", "Purral"
        };

            List<string> distritosSantaAna = new List<string>
        {
                "Santa Ana", "Salitral", "Pozos",
                "Uruca", "Piedades", "Brasil"
        };

            List<string> distritosAlajuelita = new List<string>
        {
                "Alajuelita", "San Josecito", "San Antonio",
                "Concepci�n", "San Felipe"
        };

            List<string> distritosVazquezCoronado = new List<string>
        {
            "San Isidro", "San Rafael",
                "Dulce Nombre de Jes�s", "Patalillo", "Cascajal"
        };

            List<string> distritosAcosta = new List<string>
        {
                "San Ignacio", "Guaitil", "Palmichal",
                "Cangrejal", "Sabanillas"
        };

            List<string> distritosTibas = new List<string>
        {
                "San Juan", "Cinco Esquinas",
                "Anselmo Llorente", "Le�n XIII", "Colima"
        };

            List<string> distritosMoravia = new List<string>
        {
                "San Vicente", "San Jer�nimo", "La Trinidad"
        };

            List<string> distritosMontesOca = new List<string>
        {
                "San Pedro", "Sabanilla", "Mercedes", "San Rafael"
        };

            List<string> distritosTurrubares = new List<string>
        {
                "San Pablo", "San Pedro", "San Juan de Mata",
                "San Luis", "Carara"
        };

            List<string> distritosDota = new List<string>
        {
                "Santa Mar�a", "Jard�n", "Copey"
        };

            List<string> distritosCurridabat = new List<string>
        {
                "Curridabat", "Granadilla", "S�nchez", "Tirrases"
        };

            List<string> distritosP�rezZeledon = new List<string>
        {
                "San Isidro de El General", "El General",
                "Daniel Flores", "Rivas", "San Pedro",
                "Platanares", "Pejibaye", "Caj�n",
                "Bar�", "R�o Nuevo", "P�ramo", "La Amistad"
        };

            List<string> distritosLeonCortesCastro = new List<string>
        {
                "San Pablo", "San Andr�s", "Llano Bonito",
                "San Isidro", "Santa Cruz", "San Antonio"
        };

            //Distritos de cada cant�n en Alajuela
            distritosAlajuela = new List<string> { "Alajuela", "San Jos�", "Carrizal", "San Antonio", "Gu�cima", "San Isidro", "Sabanilla", "San Rafael", "R�o Segundo"
                , "Desamparados", "Turr�cares", "Tambor", "La Garita", "Sarapiqu�" };
            distritosSanRamon = new List<string> { "San Ram�n", "Santiago", "San Juan", "Piedades Norte", "Piedades Sur", "San Rafael", "San Isidro", "�ngeles", "Alfaro", "Volio",
                "Concepci�n", "Zapotal", "Pe�as Blancas", "San Lorenzo" };
            distritosGrecia = new List<string> { "Grecia", "San Isidro", "San Jos�", "San Roque", "Tacares", "Puente de Piedra", "Bol�var" };
            distritosSanMateo = new List<string> { "San Mateo", "Desmonte", "Jes�s Mar�a", "Labrador" };
            distritosAtenas = new List<string> { "Atenas", "Jes�s", "Mercedes", "San Isidro", "Concepci�n", "San Jos�", "Santa Eulalia", "Escobal" };
            distritosNaranjo = new List<string> { "Naranjo", "San Miguel", "San Jos�", "Cirr� Sur", "San Jer�nimo", "San Juan", "El Rosario", "Palmitos" };
            distritosPalmares = new List<string> { "Palmares", "Zaragoza", "Buenos Aires", "Santiago", "Candelaria", "Esquipulas", "La Granja" };
            distritosPoas = new List<string> { "San Pedro", "San Juan", "San Rafael", "Carrillos", "Sabana Redonda" };
            distritosOrotina = new List<string> { "Orotina", "El Mastate", "Hacienda Vieja", "Coyolar", "La Ceiba" };
            distritosSanCarlos = new List<string> { "Quesada", "Florencia", "Buenavista", "Aguas Zarcas", "Venecia", "Pital", "La Fortuna",
                "La Tigra", "La Palmera", "Venado", "Cutris", "Monterrey", "Pocosol" };
            distritosZarcero = new List<string> { "Zarcero", "Laguna", "Tapesco", "Palmira", "Guadalupe", "Zapote", "Brisas" };
            distritosSarch� = new List<string> { "Sarch� Norte", "Sarch� Sur", "Toro Amarillo", "San Pedro", "Rodr�guez" };
            distritosUpala = new List<string> { "Upala", "Aguas Claras", "San Jos�", "Bijagua", "Delicias", "Dos R�os", "Yolillal", "Canalete" };
            distritosLosChiles = new List<string> { "Los Chiles", "Ca�o Negro", "El Amparo", "San Jorge" };
            distritosGuatuso = new List<string> { "San Rafael", "Buenavista", "Cote", "Katira" };
            distritosRioCuarto = new List<string> { "R�o Cuarto", "Santa Isabel", "Santa Rita" };

            // Distritos de cada cant�n en la provincia de Cartago
            distritosCartago = new List<string> { "Oriental", "Occidental", "Carmen", "San Nicol�s",
            "Aguacaliente", "Guadalupe", "Corralillo", "Tierra Blanca",
            "Dulce Nombre", "Llano Grande", "Quebradilla"};
            distritosPara�so = new List<string> { "Para�so", "Santiago", "Orosi", "Cach�", "Llanos de Santa Luc�a", "Birrisito" };
            distritosLaUnion = new List<string> { "Tres R�os", "San Diego", "San Juan", "San Rafael", "Concepci�n", "Dulce Nombre", "San Ram�n", "R�o Azul" };
            distritosJimenez = new List<string> { "Juan Vi�as", "Tucurrique", "Pejibaye", "La Victoria" };
            distritosTurrialba = new List<string> { "Turrialba", "La Suiza", "Peralta", "Santa Cruz", "Santa Teresita", "Pavones", "Tuis", "Tayutic",
                "Santa Rosa", "Tres Equis", "La Isabel", "Chirrip�"};
            distritosAlvarado = new List<string> { "Pacayas", "Cervantes", "Capellades" };
            distritosOreamuno = new List<string> { "San Rafael", "Cot", "Potrero Cerrado", "Cipreses", "Santa Rosa" };
            distritosElGuarco = new List<string> { "El Tejar", "San Isidro", "Tobosi", "Patio de Agua" };

            // Distritos de cada cant�n en la provincia de Heredia
            distritosHeredia = new List<string>
        {
            "Heredia", "Mercedes", "San Francisco", "Ulloa", "Varablanca"
        };

            distritosBarva = new List<string>
        {
            "Barva", "San Pedro", "San Pablo", "San Roque", "Santa Luc�a", "San Jos� de la Monta�a"
        };

            distritosSantoDomingo = new List<string>
        {
            "Santo Domingo", "San Vicente", "San Miguel", "Paracito",
            "Santo Tom�s", "Santa Rosa", "Tures", "Par�"
        };

            distritosSanRafael = new List<string>
        {
            "San Rafael", "San Josecito", "Santiago", "�ngeles", "Concepci�n"
        };

            distritosSanIsidro = new List<string>
        {
            "San Isidro", "San Jos�", "Concepci�n", "San Francisco"
        };

            distritosBelen = new List<string>
        {
            "San Antonio", "La Ribera", "La Asunci�n"
        };

            distritosFlores = new List<string>
        {
            "San Joaqu�n", "Barrantes", "Llorente"
        };

            distritosSanPablo = new List<string>
        {
            "San Pablo", "Rinc�n de Sabanilla"
        };

            distritosSarapiqui = new List<string>
        {
            "Puerto Viejo", "La Virgen", "Horquetas", "Llanuras del Gaspar", "Cure�a"
        };

            distritosSantaBarbara = new List<string>
        {
                "Santa B�rbara", "San Pedro", "San Juan", "Jes�s", "Santo Domingo", "Purab�"
        };



            //Distritos de Guanacaste
            distritosLiberia = new List<string>();
            distritosNicoya = new List<string>();
            distritosSantaCruz = new List<string>();
            distritosBagaces = new List<string>();
            distritosCarrillo = new List<string>();
            distritosCa�as = new List<string>();
            distritosAbangares = new List<string>();
            distritosTilar�n = new List<string>();
            distritosNandayure = new List<string>();
            distritosLaCruz = new List<string>();
            distritosHojancha = new List<string>();

            distritosLiberia.Add("Liberia");
            distritosLiberia.Add("Ca�as Dulces");
            distritosLiberia.Add("Mayorga");
            distritosLiberia.Add("Nacascolo");
            distritosLiberia.Add("Curuband�");

            // Inicializar distritos de Nicoya
            distritosNicoya.Add("Nicoya");
            distritosNicoya.Add("Mansi�n");
            distritosNicoya.Add("San Antonio");
            distritosNicoya.Add("Quebrada Honda");
            distritosNicoya.Add("S�mara");
            distritosNicoya.Add("Nosara");
            distritosNicoya.Add("Bel�n de Nosarita");

            // Inicializar distritos de Santa Cruz
            distritosSantaCruz.Add("Santa Cruz");
            distritosSantaCruz.Add("Bols�n");
            distritosSantaCruz.Add("Veintisiete de Abril");
            distritosSantaCruz.Add("Tempate");
            distritosSantaCruz.Add("Cartagena");
            distritosSantaCruz.Add("Cuajiniquil");
            distritosSantaCruz.Add("Diri�");
            distritosSantaCruz.Add("Cabo Velas");
            distritosSantaCruz.Add("Tamarindo");

            // Inicializar distritos de Bagaces
            distritosBagaces.Add("Bagaces");
            distritosBagaces.Add("La Fortuna");
            distritosBagaces.Add("Mogote");
            distritosBagaces.Add("R�o Naranjo");

            // Inicializar distritos de Carrillo
            distritosCarrillo.Add("Filadelfia");
            distritosCarrillo.Add("Palmira");
            distritosCarrillo.Add("Sardinal");
            distritosCarrillo.Add("Bel�n");

            // Inicializar distritos de Ca�as
            distritosCa�as.Add("Ca�as");
            distritosCa�as.Add("Palmira");
            distritosCa�as.Add("San Miguel");
            distritosCa�as.Add("Bebedero");
            distritosCa�as.Add("Porozal");

            // Inicializar distritos de Abangares
            distritosAbangares.Add("Las Juntas");
            distritosAbangares.Add("Sierra");
            distritosAbangares.Add("San Juan");
            distritosAbangares.Add("Colorado");

            // Inicializar distritos de Tilar�n
            distritosTilar�n.Add("Tilar�n");
            distritosTilar�n.Add("Quebrada Grande");
            distritosTilar�n.Add("Tronadora");
            distritosTilar�n.Add("Santa Rosa");
            distritosTilar�n.Add("L�bano");
            distritosTilar�n.Add("Tierras Morenas");
            distritosTilar�n.Add("Arenal");
            distritosTilar�n.Add("Cabeceras");

            // Inicializar distritos de Nandayure
            distritosNandayure.Add("Carmona");
            distritosNandayure.Add("Santa Rita");
            distritosNandayure.Add("Zapotal");
            distritosNandayure.Add("San Pablo");
            distritosNandayure.Add("Porvenir");
            distritosNandayure.Add("Bejuco");

            // Inicializar distritos de La Cruz
            distritosLaCruz.Add("La Cruz");
            distritosLaCruz.Add("Santa Cecilia");
            distritosLaCruz.Add("La Garita");
            distritosLaCruz.Add("Santa Elena");

            // Inicializar distritos de Hojancha
            distritosHojancha.Add("Hojancha");
            distritosHojancha.Add("Monte Romo");
            distritosHojancha.Add("Puerto Carrillo");
            distritosHojancha.Add("Huacas");
            distritosHojancha.Add("Matamb�");

            //Distritos de Puntarenas
            distritosPuntarenas = new List<string>();
            distritosEsparza = new List<string>();
            distritosBuenosAires = new List<string>();
            distritosMontesDeOro = new List<string>();
            distritosOsa = new List<string>();
            distritosQuepos = new List<string>();
            distritosGolfito = new List<string>();
            distritosCotoBrus = new List<string>();
            distritosParrita = new List<string>();
            distritosCorredores = new List<string>();
            distritosGarabito = new List<string>();

            // Inicializar distritos de Puntarenas
            distritosPuntarenas.Add("Puntarenas");
            distritosPuntarenas.Add("Pitahaya");
            distritosPuntarenas.Add("Chomes");
            distritosPuntarenas.Add("Lepanto");
            distritosPuntarenas.Add("Paquera");
            distritosPuntarenas.Add("Manzanillo");
            distritosPuntarenas.Add("Guacimal");
            distritosPuntarenas.Add("Barranca");
            distritosPuntarenas.Add("Isla del Coco");
            distritosPuntarenas.Add("C�bano");
            distritosPuntarenas.Add("Chacarita");
            distritosPuntarenas.Add("Chira");
            distritosPuntarenas.Add("Acapulco");
            distritosPuntarenas.Add("El Roble");
            distritosPuntarenas.Add("Arancibia");

            // Inicializar distritos de Esparza
            distritosEsparza.Add("Esp�ritu Santo");
            distritosEsparza.Add("San Juan Grande");
            distritosEsparza.Add("Macacona");
            distritosEsparza.Add("San Rafael");
            distritosEsparza.Add("San Jer�nimo");
            distritosEsparza.Add("Caldera");

            // Inicializar distritos de Buenos Aires
            distritosBuenosAires.Add("Buenos Aires");
            distritosBuenosAires.Add("Volc�n");
            distritosBuenosAires.Add("Potrero Grande");
            distritosBuenosAires.Add("Boruca");
            distritosBuenosAires.Add("Pilas");
            distritosBuenosAires.Add("Colinas");
            distritosBuenosAires.Add("Ch�nguena");
            distritosBuenosAires.Add("Biolley");
            distritosBuenosAires.Add("Brunka");

            // Inicializar distritos de Montes de Oro
            distritosMontesDeOro.Add("Miramar");
            distritosMontesDeOro.Add("La Uni�n");
            distritosMontesDeOro.Add("San Isidro");

            // Inicializar distritos de Osa
            distritosOsa.Add("Puerto Cort�s");
            distritosOsa.Add("Palmar");
            distritosOsa.Add("Sierpe");
            distritosOsa.Add("Bah�a Ballena");
            distritosOsa.Add("Piedras Blancas");
            distritosOsa.Add("Bah�a Drake");

            // Inicializar distritos de Quepos
            distritosQuepos.Add("Quepos");
            distritosQuepos.Add("Savegre");
            distritosQuepos.Add("Naranjito");

            // Inicializar distritos de Golfito
            distritosGolfito.Add("Golfito");
            distritosGolfito.Add("Guaycar�");
            distritosGolfito.Add("Pav�n");

            // Inicializar distritos de Coto Brus
            distritosCotoBrus.Add("San Vito");
            distritosCotoBrus.Add("Sabalito");
            distritosCotoBrus.Add("Aguabuena");
            distritosCotoBrus.Add("Limoncito");
            distritosCotoBrus.Add("Pittier");
            distritosCotoBrus.Add("Guti�rrez Braun");

            // Inicializar distritos de Parrita
            distritosParrita.Add("Parrita");

            // Inicializar distritos de Corredores
            distritosCorredores.Add("Corredor");
            distritosCorredores.Add("La Cuesta");
            distritosCorredores.Add("Canoas");
            distritosCorredores.Add("Laurel");

            // Inicializar distritos de Garabito
            distritosGarabito.Add("Jac�");
            distritosGarabito.Add("T�rcoles");
            distritosGarabito.Add("Lagunillas");
            distritosGarabito.Add("Monteverde");
            distritosGarabito.Add("Puerto Jim�nez");

            //Distritos de Lim�n
            distritosLim�n = new List<string>();
            distritosPococ� = new List<string>();
            distritosSiquirres = new List<string>();
            distritosTalamanca = new List<string>();
            distritosMatina = new List<string>();
            distritosGu�cimo = new List<string>();

            // Inicializar distritos de Lim�n
            distritosLim�n.Add("Lim�n");
            distritosLim�n.Add("Valle La Estrella");
            distritosLim�n.Add("R�o Blanco");
            distritosLim�n.Add("Matama");

            // Inicializar distritos de Pococ�
            distritosPococ�.Add("Gu�piles");
            distritosPococ�.Add("Jim�nez");
            distritosPococ�.Add("La Rita");
            distritosPococ�.Add("Roxana");
            distritosPococ�.Add("Cariari");
            distritosPococ�.Add("Colorado");
            distritosPococ�.Add("La Colonia");

            // Inicializar distritos de Siquirres
            distritosSiquirres.Add("Siquirres");
            distritosSiquirres.Add("Pacuarito");
            distritosSiquirres.Add("Florida");
            distritosSiquirres.Add("Germania");
            distritosSiquirres.Add("El Cairo");
            distritosSiquirres.Add("Alegr�a");
            distritosSiquirres.Add("Reventaz�n");

            // Inicializar distritos de Talamanca
            distritosTalamanca.Add("Bratsi");
            distritosTalamanca.Add("Sixaola");
            distritosTalamanca.Add("Cahuita");
            distritosTalamanca.Add("Telire");

            // Inicializar distritos de Matina
            distritosMatina.Add("Matina");
            distritosMatina.Add("Bat�n");
            distritosMatina.Add("Carrandi");

            // Inicializar distritos de Gu�cimo
            distritosGu�cimo.Add("Gu�cimo");
            distritosGu�cimo.Add("Mercedes");
            distritosGu�cimo.Add("Pocora");
            distritosGu�cimo.Add("R�o Jim�nez");
            distritosGu�cimo.Add("Duacar�");
        }
    }
}
