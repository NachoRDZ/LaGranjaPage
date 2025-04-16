using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;

        private List<Empleado> _empleados = new List<Empleado>();

        private List<Animal> _animales = new List<Animal>();

        private List<Potrero> _potreros = new List<Potrero>();

        private List<Vacuna> _vacunas = new List<Vacuna>();

        private List<VacunaRecibida> _vacunasRecibidas = new List<VacunaRecibida>();

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }

        public enum TipoAlimentacion
        {
            Grano = 1,
            Pastura = 2
        }

        public enum Estado
        {
            Libre = 1,
            EnPotrero = 2
        }

        public IEnumerable<Empleado> Empleados
        {
            get { return _empleados; }
        }

        public IEnumerable<Animal> Animales
        {
            get { return _animales; }
        }

        public IEnumerable<Vacuna> Vacunas
        {
            get { return _vacunas; }
        }

        public IEnumerable<Potrero> Potreros
        {
            get { return _potreros; }
        }

        public Sistema()
        {
            Precargar();
        }


        public void Precargar()
        {
            PrecargarPeones();
            PrecargarCapataces();
            PrecargarBovinos();
            PrecargarOvinos();
            PrecargarVacunas();
            PrecargarPotreros();
            PrecargarTareas();
            PrecargarVacunasRecibidas();
            PrecargarAnimalesPotrero();
        }

        private void PrecargarPeones()
        {
            Peon unP1 = new(true, "Pablo.Pepito@gmail.com", "EsUnaContrasenia1", "Pablo Pepito", new DateTime(2020, 01, 01));
            AgregarPeon(unP1);
            Peon unP2 = new(true, "Armando.Armani@gmail.com", "EsUnaContrasenia2", "Armando Armani", new DateTime(2020, 01, 02));
            AgregarPeon(unP2);
            Peon unP3 = new(false, "Brandon.Bandini@outlook.com", "EsUnaContrasenia3", "Brandon Bandini", new DateTime(2020, 01, 03));
            AgregarPeon(unP3);
            Peon unP4 = new(false, "Camilo.Crack@outlook.com", "EsUnaContrasenia4", "Camilo Crack", new DateTime(2020, 01, 04));
            AgregarPeon(unP4);
            Peon unP5 = new(true, "Daniel.Dracula@gmail.com", "EsUnaContrasenia5", "Daniel Dracula", new DateTime(2020, 01, 05));
            AgregarPeon(unP5);
            Peon unP6 = new(true, "Ezequiel.Estonia@outlook.com", "EsUnaContrasenia6", "Ezequiel Estonia", new DateTime(2021, 05, 05));
            AgregarPeon(unP6);
            Peon unP7 = new(false, "Franco.Franco@gmail.com", "EsUnaContrasenia7", "Franco Franco", new DateTime(2021, 06, 06));
            AgregarPeon(unP7);
            Peon unP8 = new(true, "Gonzalo.Grande@outlook.com", "EsUnaContrasenia8", "Gonzalo Grande", new DateTime(2021, 07, 07));
            AgregarPeon(unP8);
            Peon unP9 = new(false, "Holder.Holding@gmail.com", "EsUnaContrasenia9", "Holder Holding", new DateTime(2022, 10, 15));
            AgregarPeon(unP9);
            Peon unP10 = new(true, "Immanuel.Iman@gmail.com", "EsUnaContrasenia10", "Immanuel Iman", new DateTime(2021, 12, 06));
            AgregarPeon(unP10);
            Peon unP11 = new(true, "peon@gmail.com", "peon", "Peon", new DateTime(2021, 12, 06));
            AgregarPeon(unP11);
        }

        private void PrecargarCapataces()
        {
            Capataz unC1 = new(5, "Badan.Valentino@empresa.com", "EsUnaContrasenia11", "Badan Valentino", new DateTime(1990, 02, 02));
            AgregarCapataz(unC1);
            Capataz unC2 = new(5, "Paco.Rabanne@empresa.com", "EsUnaContrasenia12", "Paco Rabanne", new DateTime(1995, 05, 05));
            AgregarCapataz(unC2);
            Capataz unC3 = new(5, "admin@gmail.com", "admin", "Admin", new DateTime(1988, 05, 07));
            AgregarCapataz(unC3);
        }

        private void PrecargarBovinos()
        {
            Bovino unB1 = new("Pastura", 2, "Bovino01", "Hembra", "Hereford", new DateTime(2000, 01, 01), 2000, 10, 510, false, "EnPotrero");
            AgregarBovino(unB1);
            Bovino unB2 = new("Grano", 2, "Bovino02", "Macho", "Angus", new DateTime(2001, 02, 15), 2500, 15, 600, true, "Libre");
            AgregarBovino(unB2);
            Bovino unB3 = new("Pastura", 2, "Bovino03", "Hembra", "Hereford", new DateTime(2000, 01, 01), 2000, 10, 510, false, "EnPotrero");
            AgregarBovino(unB3);
            Bovino unB4 = new("Grano", 2, "Bovino04", "Macho", "Angus", new DateTime(2001, 02, 15), 2500, 15, 600, false, "Libre");
            AgregarBovino(unB4);
            Bovino unB5 = new("Pastura", 2, "Bovino05", "Hembra", "Simmental", new DateTime(1999, 05, 20), 1800, 12, 480, false, "EnPotrero");
            AgregarBovino(unB5);
            Bovino unB6 = new("Pastura", 2, "Bovino06", "Macho", "Limousin", new DateTime(2002, 11, 10), 2200, 14, 550, true, "EnPotrero");
            AgregarBovino(unB6);
            Bovino unB7 = new("Grano", 2, "Bovino07", "Macho", "Charolais", new DateTime(2003, 03, 05), 2300, 13, 580, false, "Libre");
            AgregarBovino(unB7);
            Bovino unB8 = new("Pastura", 2, "Bovino08", "Hembra", "Guzerá", new DateTime(2004, 07, 15), 1900, 11, 490, false, "EnPotrero");
            AgregarBovino(unB8);
            Bovino unB9 = new("Grano", 2, "Bovino09", "Macho", "Brahman", new DateTime(2005, 09, 20), 2400, 16, 620, true, "Libre");
            AgregarBovino(unB9);
            Bovino unB10 = new("Pastura", 2, "Bovino10", "Hembra", "Nelore", new DateTime(2006, 12, 25), 2100, 12, 520, false, "EnPotrero");
            AgregarBovino(unB10);
            Bovino unB11 = new("Pastura", 2, "Bovino11", "Macho", "Holstein", new DateTime(2007, 04, 30), 2150, 14, 540, true, "EnPotrero");
            AgregarBovino(unB11);
            Bovino unB12 = new("Grano", 2, "Bovino12", "Hembra", "Pardo Suizo", new DateTime(2008, 10, 10), 2550, 15, 580, true, "Libre");
            AgregarBovino(unB12);
            Bovino unB13 = new("Pastura", 2, "Bovino13", "Macho", "Jersey", new DateTime(2009, 08, 05), 1950, 13, 510, false, "EnPotrero");
            AgregarBovino(unB13);
            Bovino unB14 = new("Grano", 2, "Bovino14", "Hembra", "Murray Grey", new DateTime(2010, 06, 20), 2600, 16, 620, false, "Libre");
            AgregarBovino(unB14);
            Bovino unB15 = new("Pastura", 2, "Bovino15", "Macho", "Santa Gertrudis", new DateTime(2011, 03, 15), 2050, 14, 530, true, "EnPotrero");
            AgregarBovino(unB15);
            Bovino unB16 = new("Grano", 2, "Bovino16", "Hembra", "Angus", new DateTime(2012, 09, 10), 2400, 18, 600, false, "Libre");
            AgregarBovino(unB16);
            Bovino unB17 = new("Pastura", 2, "Bovino17", "Macho", "Hereford", new DateTime(2013, 05, 25), 2150, 15, 550, true, "EnPotrero");
            AgregarBovino(unB17);
            Bovino unB18 = new("Grano", 2, "Bovino18", "Hembra", "Simmental", new DateTime(2014, 07, 30), 2550, 16, 620, false, "Libre");
            AgregarBovino(unB18);
            Bovino unB19 = new("Pastura", 2, "Bovino19", "Macho", "Charolais", new DateTime(2015, 04, 05), 2250, 14, 530, true, "EnPotrero");
            AgregarBovino(unB19);
            Bovino unB20 = new("Grano", 2, "Bovino20", "Hembra", "Limousin", new DateTime(2016, 08, 15), 2650, 18, 600, false, "Libre");
            AgregarBovino(unB20);
            Bovino unB21 = new("Pastura", 2, "Bovino21", "Macho", "Gelbvieh", new DateTime(2017, 01, 20), 2050, 15, 550, true, "EnPotrero");
            AgregarBovino(unB21);
            Bovino unB22 = new("Grano", 2, "Bovino22", "Hembra", "Brahman", new DateTime(2018, 10, 25), 2700, 16, 620, false, "Libre");
            AgregarBovino(unB22);
            Bovino unB23 = new("Pastura", 2, "Bovino23", "Macho", "Brangus", new DateTime(2019, 06, 10), 2150, 14, 530, true, "EnPotrero");
            AgregarBovino(unB23);
            Bovino unB24 = new("Grano", 2, "Bovino24", "Hembra", "Angus", new DateTime(2020, 03, 15), 2800, 18, 600, false, "Libre");
            AgregarBovino(unB24);
            Bovino unB25 = new("Pastura", 2, "Bovino25", "Macho", "Hereford", new DateTime(2021, 08, 20), 2250, 15, 550, true, "EnPotrero");
            AgregarBovino(unB25);
            Bovino unB26 = new("Grano", 2, "Bovino26", "Hembra", "Simmental", new DateTime(2022, 11, 05), 2900, 16, 620, false, "Libre");
            AgregarBovino(unB26);
            Bovino unB27 = new("Pastura", 2, "Bovino27", "Macho", "Charolais", new DateTime(2023, 02, 10), 2350, 14, 530, true, "EnPotrero");
            AgregarBovino(unB27);
            Bovino unB28 = new("Grano", 2, "Bovino28", "Hembra", "Limousin", new DateTime(2012, 09, 10), 3000, 18, 600, false, "Libre");
            AgregarBovino(unB28);
            Bovino unB29 = new("Pastura", 2, "Bovino29", "Macho", "Gelbvieh", new DateTime(2004, 07, 15), 2450, 15, 550, true, "EnPotrero");
            AgregarBovino(unB29);
            Bovino unB30 = new("Grano", 2, "Bovino30", "Hembra", "Brahman", new DateTime(2008, 10, 10), 3100, 16, 620, false, "Libre");
            AgregarBovino(unB30);
        }

        private void PrecargarOvinos()
        {
            Ovino unO01 = new(2, 2, 5, "Ovino01", "Macho", "Dorper", new DateTime(2000, 01, 01), 2000, 15, 75, false, "EnPotrero");
            AgregarOvino(unO01);
            Ovino unO02 = new(4, 2, 5, "Ovino02", "Hembra", "Merina", new DateTime(2000, 01, 01), 2000, 15, 75, true, "Libre");
            AgregarOvino(unO02);
            Ovino unO03 = new(3, 2, 5, "Ovino03", "Macho", "Suffolk", new DateTime(2017, 05, 12), 2500, 20, 85, false, "EnPotrero");
            AgregarOvino(unO03);
            Ovino unO04 = new(5, 2, 5, "Ovino04", "Hembra", "Rambouillet", new DateTime(2017, 08, 23), 1800, 18, 70, true, "Libre");
            AgregarOvino(unO04);
            Ovino unO05 = new(4, 2, 5, "Ovino05", "Macho", "Cotswold", new DateTime(2019, 03, 17), 2200, 22, 80, false, "EnPotrero");
            AgregarOvino(unO05);
            Ovino unO06 = new(2, 2, 5, "Ovino06", "Hembra", "Lincoln", new DateTime(2020, 01, 05), 1900, 17, 65, true, "Libre");
            AgregarOvino(unO06);
            Ovino unO07 = new(3, 2, 5, "Ovino07", "Macho", "Corriedale", new DateTime(2016, 11, 30), 2400, 24, 90, false, "EnPotrero");
            AgregarOvino(unO07);
            Ovino unO08 = new(4, 2, 5, "Ovino08", "Hembra", "Cheviot", new DateTime(2017, 09, 18), 2100, 20, 75, true, "Libre");
            AgregarOvino(unO08);
            Ovino unO09 = new(5, 2, 5, "Ovino09", "Macho", "Hampshire", new DateTime(2018, 04, 22), 2700, 25, 95, false, "EnPotrero");
            AgregarOvino(unO09);
            Ovino unO10 = new(2, 2, 5, "Ovino10", "Hembra", "Dorset", new DateTime(2019, 07, 10), 2000, 18, 70, true, "Libre");
            AgregarOvino(unO10);
            Ovino unO11 = new(3, 2, 5, "Ovino11", "Macho", "Romney", new DateTime(2017, 12, 05), 2600, 26, 100, false, "EnPotrero");
            AgregarOvino(unO11);
            Ovino unO12 = new(4, 2, 5, "Ovino12", "Hembra", "Targhee", new DateTime(2018, 02, 14), 2300, 22, 85, true, "Libre");
            AgregarOvino(unO12);
            Ovino unO13 = new(5, 2, 5, "Ovino13", "Macho", "Merino", new DateTime(2016, 10, 28), 2500, 24, 95, false, "EnPotrero");
            AgregarOvino(unO13);
            Ovino unO14 = new(2, 2, 5, "Ovino14", "Hembra", "Dorper", new DateTime(2019, 04, 15), 2200, 20, 75, true, "Libre");
            AgregarOvino(unO14);
            Ovino unO15 = new(3, 2, 5, "Ovino15", "Macho", "Suffolk", new DateTime(2017, 11, 20), 2300, 23, 90, false, "EnPotrero");
            AgregarOvino(unO15);
            Ovino unO16 = new(4, 2, 5, "Ovino16", "Hembra", "Merino", new DateTime(2018, 06, 10), 1800, 18, 70, true, "Libre");
            AgregarOvino(unO16);
            Ovino unO17 = new(5, 2, 5, "Ovino17", "Macho", "Dorper", new DateTime(2019, 02, 28), 2100, 21, 85, false, "EnPotrero");
            AgregarOvino(unO17);
            Ovino unO18 = new(6, 2, 5, "Ovino18", "Hembra", "Suffolk", new DateTime(2017, 09, 05), 1900, 19, 75, true, "Libre");
            AgregarOvino(unO18);
            Ovino unO19 = new(7, 2, 5, "Ovino19", "Macho", "Merino", new DateTime(2018, 12, 20), 2000, 20, 80, false, "EnPotrero");
            AgregarOvino(unO19);
            Ovino unO20 = new(2, 2, 5, "Ovino20", "Hembra", "Dorper", new DateTime(2016, 08, 15), 2200, 22, 90, true, "Libre");
            AgregarOvino(unO20);
            Ovino unO21 = new(3, 2, 5, "Ovino21", "Macho", "Suffolk", new DateTime(2019, 05, 30), 1900, 19, 75, false, "EnPotrero");
            AgregarOvino(unO21);
            Ovino unO22 = new(4, 2, 5, "Ovino22", "Hembra", "Merino", new DateTime(2017, 07, 25), 2100, 21, 85, true, "Libre");
            AgregarOvino(unO22);
            Ovino unO23 = new(3, 2, 5, "Ovino23", "Macho", "Dorper", new DateTime(2018, 04, 12), 1800, 18, 70, false, "EnPotrero");
            AgregarOvino(unO23);
            Ovino unO24 = new(3, 2, 5, "Ovino24", "Hembra", "Suffolk", new DateTime(2016, 10, 08), 2300, 23, 95, true, "Libre");
            AgregarOvino(unO24);
            Ovino unO25 = new(5, 2, 5, "Ovino25", "Macho", "Merino", new DateTime(2019, 01, 05), 2000, 20, 80, false, "EnPotrero");
            AgregarOvino(unO25);
            Ovino unO26 = new(6, 2, 5, "Ovino26", "Hembra", "Dorper", new DateTime(2017, 06, 20), 1900, 19, 75, true, "Libre");
            AgregarOvino(unO26);
            Ovino unO27 = new(2, 2, 5, "Ovino27", "Macho", "Suffolk", new DateTime(2018, 11, 15), 2200, 22, 90, false, "EnPotrero");
            AgregarOvino(unO27);
            Ovino unO28 = new(2, 2, 5, "Ovino28", "Hembra", "Merino", new DateTime(2016, 09, 10), 1800, 18, 70, true, "Libre");
            AgregarOvino(unO28);
            Ovino unO29 = new(6, 2, 5, "Ovino29", "Macho", "Dorper", new DateTime(2019, 03, 28), 2100, 21, 85, false, "EnPotrero");
            AgregarOvino(unO29);
            Ovino unO30 = new(6, 2, 5, "Ovino30", "Hembra", "Suffolk", new DateTime(2017, 08, 05), 1900, 19, 75, true, "Libre");
            AgregarOvino(unO30);

        }

        private void PrecargarTareas()
        {
            foreach (Empleado item in _empleados)
            {
                if (item is Peon)
                {
                    item.AgregarTarea(new Tarea("Alimentar bovinos", new DateTime(2022, 09, 14), false, new DateTime(2023, 06, 03), "Falta comida"));
                    item.AgregarTarea(new Tarea("Limpiar el establo", new DateTime(2024, 02, 15), true, new DateTime(2023, 05, 16), "Establo sucio"));
                    item.AgregarTarea(new Tarea("Sembrar maíz", new DateTime(2020, 08, 16), true, new DateTime(2023, 05, 25), "Clima favorable"));
                    item.AgregarTarea(new Tarea("Arar el campo", new DateTime(2021, 01, 17), false, new DateTime(2023, 05, 18), "Preparando para la siembra"));
                    item.AgregarTarea(new Tarea("Cosechar trigo", new DateTime(2023, 04, 18), true, new DateTime(2023, 06, 05), "Trigo maduro"));
                    item.AgregarTarea(new Tarea("Podar árboles frutales", new DateTime(2022, 09, 19), false, new DateTime(2023, 05, 20), "Mantenimiento anual"));
                    item.AgregarTarea(new Tarea("Reparar cercas", new DateTime(2021, 11, 20), true, new DateTime(2023, 05, 22), "Cercas dañadas"));
                    item.AgregarTarea(new Tarea("Ordeñar vacas", new DateTime(2023, 12, 21), false, new DateTime(2023, 05, 21), "Hora de la leche"));
                    item.AgregarTarea(new Tarea("Plantar cultivos de raíz", new DateTime(2022, 08, 22), false, new DateTime(2023, 05, 30), "Temporada de siembra"));
                    item.AgregarTarea(new Tarea("Rociar pesticidas", new DateTime(2023, 07, 23), false, new DateTime(2023, 06, 02), "Control de plagas"));
                    item.AgregarTarea(new Tarea("Desparasitar animales", new DateTime(2022, 03, 24), true, new DateTime(2023, 05, 25), "Prevención de enfermedades"));
                    item.AgregarTarea(new Tarea("Mantener abejas", new DateTime(2021, 06, 25), true, new DateTime(2023, 05, 27), "Producción de miel"));
                    item.AgregarTarea(new Tarea("Regar campos", new DateTime(2021, 10, 26), false, new DateTime(2023, 05, 31), "Sequía"));
                    item.AgregarTarea(new Tarea("Recolectar huevos", new DateTime(2022, 02, 27), false, new DateTime(2023, 05, 28), "Cosecha diaria"));
                    item.AgregarTarea(new Tarea("Limpiar Ovinos", new DateTime(2024, 03, 27), true, new DateTime(2023, 05, 28), "Baño semanal"));
                }
            }
        }

        private void PrecargarVacunas()
        {
            Vacuna vacuna1 = new("Rabies Vaccine (Inactivada)", "Vacuna inactivada contra el virus de la rabia para proteger a los perros contra esta enfermedad viral mortal.", "Virus de la rabia (Rhabdovirus)");
            AgregarVacuna(vacuna1);
            Vacuna vacuna2 = new("Canine Parvovirus Vaccine", "Vacuna para prevenir la infección por parvovirus canino, una enfermedad altamente contagiosa y a menudo fatal en perros.", "Parvovirus canino (Canine parvovirus)");
            AgregarVacuna(vacuna2);
            Vacuna vacuna3 = new("Feline Rhinotracheitis Vaccine", "Vacuna para proteger a los gatos contra la rinotraqueitis viral felina, una enfermedad respiratoria altamente contagiosa.", "Herpesvirus felino tipo 1 (Feline herpesvirus-1)");
            AgregarVacuna(vacuna3);
            Vacuna vacuna4 = new("Feline Panleukopenia Vaccine", "Vacuna para prevenir la panleucopenia felina, una enfermedad viral altamente contagiosa y a menudo fatal en gatos.", "Parvovirus felino (Feline parvovirus)");
            AgregarVacuna(vacuna4);
            Vacuna vacuna5 = new("Marek's Disease Vaccine", "Vacuna para proteger a las aves de corral, como pollos y pavos, contra la enfermedad de Marek, una enfermedad viral que causa tumores y parálisis.", "Virus de la enfermedad de Marek (Marek's disease virus)");
            AgregarVacuna(vacuna5);
            Vacuna vacuna6 = new("Newcastle Disease Vaccine", "Vacuna para proteger a las aves de corral contra la enfermedad de Newcastle, una enfermedad viral altamente contagiosa que afecta a aves de corral y aves silvestres.", "Virus de la enfermedad de Newcastle (Newcastle disease virus)");
            AgregarVacuna(vacuna6);
            Vacuna vacuna7 = new("Leptospirosis Vaccine", "Vacuna para prevenir la leptospirosis, una enfermedad bacteriana transmitida por animales infectados que puede afectar a los perros y a los humanos.", "Leptospira spp. (bacterias del género Leptospira)");
            AgregarVacuna(vacuna7);
            Vacuna vacuna8 = new("Canine Kennel Cough Vaccine", "Vacuna para proteger a los perros contra la tos de las perreras, una enfermedad respiratoria altamente contagiosa que se propaga fácilmente en entornos con muchos perros.", "Bordetella bronchiseptica (bacteria) y otros virus respiratorios caninos.");
            AgregarVacuna(vacuna8);
            Vacuna vacuna9 = new("Lyme Disease Vaccine", "Vacuna para prevenir la enfermedad de Lyme, una enfermedad bacteriana transmitida por garrapatas que puede afectar a los perros y a los humanos.", "Borrelia burgdorferi (bacteria)");
            AgregarVacuna(vacuna9);
            Vacuna vacuna10 = new("Infectious Bursal Disease Vaccine", "Vacuna para prevenir la enfermedad de Gumboro, también conocida como enfermedad infecciosa de la bolsa, una enfermedad viral altamente contagiosa que afecta a las aves de corral jóvenes.", "Virus de la enfermedad de Gumboro (Gumboro disease virus)");
            AgregarVacuna(vacuna10);
        }

        private void PrecargarVacunasRecibidas()
        {
            Vacunar(_animales[1], _vacunas[2], new DateTime(2002, 07, 14));
            Vacunar(_animales[1], _vacunas[4], new DateTime(2002, 04, 14));
            //Vacunar(_animales[1], _vacunas[5], new DateTime(2000, 07, 14)); antes de 3 meses de edad
            Vacunar(_animales[2], _vacunas[7], new DateTime(2002, 02, 14));
            Vacunar(_animales[2], _vacunas[1], new DateTime(2002, 12, 14));
            Vacunar(_animales[2], _vacunas[3], new DateTime(2002, 03, 14));
            Vacunar(_animales[4], _vacunas[6], new DateTime(2003, 03, 14));
            Vacunar(_animales[4], _vacunas[4], new DateTime(2003, 09, 14));
            Vacunar(_animales[4], _vacunas[2], new DateTime(2003, 08, 14));
            Vacunar(_animales[5], _vacunas[3], new DateTime(2003, 08, 14));
            Vacunar(_animales[5], _vacunas[7], new DateTime(2003, 02, 14));
            Vacunar(_animales[5], _vacunas[1], new DateTime(2004, 03, 14));
            Vacunar(_animales[6], _vacunas[8], new DateTime(2004, 04, 14));
            Vacunar(_animales[6], _vacunas[5], new DateTime(2004, 06, 14));
            Vacunar(_animales[6], _vacunas[2], new DateTime(2005, 01, 14));
            Vacunar(_animales[7], _vacunas[4], new DateTime(2007, 01, 14));
            Vacunar(_animales[7], _vacunas[8], new DateTime(2005, 02, 14));
            Vacunar(_animales[7], _vacunas[9], new DateTime(2005, 04, 14));
            Vacunar(_animales[8], _vacunas[1], new DateTime(2006, 09, 14));
            Vacunar(_animales[8], _vacunas[3], new DateTime(2006, 11, 14));
            Vacunar(_animales[8], _vacunas[6], new DateTime(2007, 09, 14));
            Vacunar(_animales[10], _vacunas[7], new DateTime(2011, 04, 14));
            Vacunar(_animales[10], _vacunas[4], new DateTime(2011, 05, 14));
            Vacunar(_animales[10], _vacunas[1], new DateTime(2012, 05, 14));
            Vacunar(_animales[11], _vacunas[8], new DateTime(2011, 03, 14));
            Vacunar(_animales[11], _vacunas[3], new DateTime(2012, 04, 14));
            Vacunar(_animales[11], _vacunas[5], new DateTime(2012, 05, 14));
            Vacunar(_animales[12], _vacunas[2], new DateTime(2011, 06, 14));
            //Vacunar(_animales[12], _vacunas[7], new DateTime(2005, 07, 14)); antes de 3 meses de edad
            Vacunar(_animales[12], _vacunas[7], new DateTime(2021, 08, 14));
            Vacunar(_animales[13], _vacunas[6], new DateTime(2015, 09, 14));
            Vacunar(_animales[13], _vacunas[8], new DateTime(2012, 10, 14));
            Vacunar(_animales[13], _vacunas[4], new DateTime(2015, 11, 14));
            Vacunar(_animales[14], _vacunas[9], new DateTime(2016, 12, 14));
            Vacunar(_animales[14], _vacunas[8], new DateTime(2014, 01, 14));
            Vacunar(_animales[14], _vacunas[3], new DateTime(2016, 02, 14));
            Vacunar(_animales[31], _vacunas[7], new DateTime(2017, 06, 14));
            Vacunar(_animales[31], _vacunas[4], new DateTime(2019, 07, 14));
            Vacunar(_animales[31], _vacunas[6], new DateTime(2021, 08, 14));
            Vacunar(_animales[32], _vacunas[8], new DateTime(2020, 09, 14));
            Vacunar(_animales[32], _vacunas[2], new DateTime(2019, 10, 14));
            Vacunar(_animales[32], _vacunas[8], new DateTime(2022, 11, 14));
            Vacunar(_animales[33], _vacunas[3], new DateTime(2021, 12, 14));
            Vacunar(_animales[33], _vacunas[5], new DateTime(2020, 01, 14));
            Vacunar(_animales[33], _vacunas[9], new DateTime(2018, 02, 14));
            Vacunar(_animales[34], _vacunas[1], new DateTime(2019, 12, 14));
            Vacunar(_animales[34], _vacunas[6], new DateTime(2020, 04, 14));
            Vacunar(_animales[34], _vacunas[4], new DateTime(2021, 05, 14));
            Vacunar(_animales[35], _vacunas[7], new DateTime(2020, 06, 14));
            Vacunar(_animales[35], _vacunas[2], new DateTime(2021, 07, 14));
            Vacunar(_animales[35], _vacunas[8], new DateTime(2021, 08, 14));
            Vacunar(_animales[36], _vacunas[3], new DateTime(2021, 09, 14));
            Vacunar(_animales[36], _vacunas[8], new DateTime(2022, 10, 14));
            Vacunar(_animales[36], _vacunas[5], new DateTime(2022, 11, 14));
            Vacunar(_animales[37], _vacunas[1], new DateTime(2019, 12, 14));
            //Vacunar(_animales[37], _vacunas[10], new DateTime(2019, 01, 14)); no existe _vacunas[10]
            Vacunar(_animales[37], _vacunas[4], new DateTime(2021, 02, 14));
            Vacunar(_animales[38], _vacunas[6], new DateTime(2019, 03, 14));
            Vacunar(_animales[38], _vacunas[2], new DateTime(2020, 04, 14));
            Vacunar(_animales[38], _vacunas[7], new DateTime(2019, 05, 14));
            Vacunar(_animales[39], _vacunas[3], new DateTime(2021, 06, 14));
            Vacunar(_animales[39], _vacunas[8], new DateTime(2020, 07, 14));
            Vacunar(_animales[39], _vacunas[8], new DateTime(2022, 08, 14));
            Vacunar(_animales[40], _vacunas[5], new DateTime(2021, 09, 14));
            Vacunar(_animales[40], _vacunas[1], new DateTime(2022, 10, 14));
            Vacunar(_animales[40], _vacunas[4], new DateTime(2020, 11, 14));
            Vacunar(_animales[41], _vacunas[9], new DateTime(2021, 12, 14));
            Vacunar(_animales[41], _vacunas[7], new DateTime(2022, 01, 14));
            Vacunar(_animales[41], _vacunas[2], new DateTime(2021, 02, 14));
            Vacunar(_animales[43], _vacunas[1], new DateTime(2019, 11, 14));
            Vacunar(_animales[43], _vacunas[6], new DateTime(2022, 07, 14));
            Vacunar(_animales[43], _vacunas[8], new DateTime(2019, 08, 14));
            Vacunar(_animales[44], _vacunas[3], new DateTime(2020, 09, 14));
            Vacunar(_animales[44], _vacunas[7], new DateTime(2021, 10, 14));
            Vacunar(_animales[44], _vacunas[2], new DateTime(2022, 11, 14));
            //Vacunar(_animales[60], _vacunas[2], new DateTime(2022, 11, 14)); no existe Animales[60]
        }

        static void Vacunar(Animal animal, Vacuna vacuna, DateTime fechaVacunacion)
        {
            if ((fechaVacunacion - animal.FechaNacimiento).TotalDays < 90)
            {
                throw new Exception($"El animal {animal.Caravana} no puede ser vacunado antes de los 3 meses de edad. nace: {animal.FechaNacimiento} - vacunado: {fechaVacunacion}");
            }

            DateTime fechaVencimiento = fechaVacunacion.AddYears(1);

            animal.VacunarAnimal(vacuna, fechaVacunacion, fechaVencimiento);
        }

        private void PrecargarPotreros()
        {
            Potrero potrero1 = new("Potrero de pasto alto", 20, 50);
            AgregarPotrero(potrero1);
            Potrero potrero2 = new("Potrero para ganado vacuno", 30, 100);
            AgregarPotrero(potrero2);
            Potrero potrero3 = new("Potrero de pasto fresco", 15, 40);
            AgregarPotrero(potrero3);
            Potrero potrero4 = new("Potrero de pasto seco", 25, 60);
            AgregarPotrero(potrero4);
            Potrero potrero5 = new("Potrero para caballos", 10, 30);
            AgregarPotrero(potrero5);
            Potrero potrero6 = new("Potrero de pasto verde", 35, 80);
            AgregarPotrero(potrero6);
            Potrero potrero7 = new("Potrero en pendiente", 18, 45);
            AgregarPotrero(potrero7);
            Potrero potrero8 = new("Potrero para ovejas", 12, 35);
            AgregarPotrero(potrero8);
            Potrero potrero9 = new("Potrero de pasto silvestre", 22, 55);
            AgregarPotrero(potrero9);
            Potrero potrero10 = new("Potrero de pasto cultivado", 28, 70);
            AgregarPotrero(potrero10);
        }

        public void BuscarPotrero(int hectareas, int capacidad)
        {
            bool encontrados = false;
            foreach (Potrero item in Potreros)
            {
                if (hectareas < item.CantHectareas && capacidad < item.CapacidadMax)
                {
                    Console.WriteLine($"Email: {item.Id} - Descripcion: {item.Descripcion} - Cant. Hectareas: {item.CantHectareas} - Capacidad: {item.CapacidadMax}");
                    encontrados = true;
                }
            }
            if (!encontrados)
            {
                throw new Exception("No se encontro ningun potrero con esos datos.");
            }
        }

        public void AgregarPeon(Peon peon)
        {
            if (peon == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            peon.Validar();
            if (_empleados.Contains(peon))
            {
                throw new Exception($"El peon ya existe con el nombre {peon.Nombre}");
            }
            _empleados.Add(peon);
        }

        public void AgregarCapataz(Capataz capataz)
        {
            if (capataz == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            capataz.Validar();
            if (_empleados.Contains(capataz))
            {
                throw new Exception($"El capataz ya existe con el nombre {capataz.Nombre}");
            }
            _empleados.Add(capataz);
        }

        public void AgregarBovino(Bovino bovino)
        {
            if (bovino == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            bovino.Validar();
            if (_animales.Contains(bovino))
            {
                throw new Exception($"El Bovino ya existe con el nombre {bovino.Caravana}");
            }
            _animales.Add(bovino);
        }

        public void AgregarOvino(Ovino ovino)
        {
            if (ovino == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            ovino.Validar();
            if (_animales.Contains(ovino))
            {
                throw new Exception($"El Ovino ya existe con el nombre {ovino.Caravana}");
            }
            _animales.Add(ovino);
        }

        public void AgregarPotrero(Potrero potrero)
        {
            if (potrero == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            potrero.Validar();
            if (_potreros.Contains(potrero))
            {
                throw new Exception($"El Potrero ya existe con el Id {potrero.Id}");
            }
            _potreros.Add(potrero);
        }

        public void AgregarVacuna(Vacuna vacuna)
        {
            if (vacuna == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            vacuna.Validar();
            if (_vacunas.Contains(vacuna))
            {
                throw new Exception($"La vacuna ya existe con el nombre {vacuna.Nombre}");
            }
            _vacunas.Add(vacuna);
        }

        public Empleado? ObtenerEmpleadoPorEmail(string email)
        {
            foreach (Empleado item in _empleados)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<Empleado> ListadoEmpleadosPorEmail(string email)
        {
            List<Empleado> auxEmpleados = new List<Empleado>();
            foreach (Empleado item in _empleados)
            {
                if (item.Email == email)
                {
                    auxEmpleados.Add(item);
                }

            }
            return auxEmpleados;
        }

        public void CompletarTarea(int idTarea, Empleado empleado, string comentario)
        {
            foreach (Tarea item in empleado.ListarTareasIncompletas())
            {
                if(idTarea == item.Id)
                {
                    item.TareaCompleta = true;
                    item.Comentario = comentario;
                }
            }
        }

        private void PrecargarAnimalesPotrero()
        {
            AsignarAnimalAPotrero(_animales[1], _potreros[1]);
            AsignarAnimalAPotrero(_animales[2], _potreros[1]);
            AsignarAnimalAPotrero(_animales[3], _potreros[1]);
            AsignarAnimalAPotrero(_animales[4], _potreros[1]);
            AsignarAnimalAPotrero(_animales[5], _potreros[1]);
            AsignarAnimalAPotrero(_animales[6], _potreros[1]);
            AsignarAnimalAPotrero(_animales[7], _potreros[1]);
            AsignarAnimalAPotrero(_animales[8], _potreros[1]);
            AsignarAnimalAPotrero(_animales[9], _potreros[1]);
            AsignarAnimalAPotrero(_animales[10], _potreros[1]);
            AsignarAnimalAPotrero(_animales[11], _potreros[2]);
            AsignarAnimalAPotrero(_animales[12], _potreros[2]);
            AsignarAnimalAPotrero(_animales[13], _potreros[2]);
            AsignarAnimalAPotrero(_animales[14], _potreros[2]);
            AsignarAnimalAPotrero(_animales[15], _potreros[2]);
            AsignarAnimalAPotrero(_animales[16], _potreros[2]);
            AsignarAnimalAPotrero(_animales[17], _potreros[2]);
            AsignarAnimalAPotrero(_animales[18], _potreros[2]);
            AsignarAnimalAPotrero(_animales[19], _potreros[2]);
            AsignarAnimalAPotrero(_animales[20], _potreros[2]);
            AsignarAnimalAPotrero(_animales[21], _potreros[4]);
            AsignarAnimalAPotrero(_animales[22], _potreros[4]);
            AsignarAnimalAPotrero(_animales[23], _potreros[4]);
            AsignarAnimalAPotrero(_animales[24], _potreros[4]);
            AsignarAnimalAPotrero(_animales[25], _potreros[4]);
            AsignarAnimalAPotrero(_animales[26], _potreros[4]);
            AsignarAnimalAPotrero(_animales[27], _potreros[4]);
            AsignarAnimalAPotrero(_animales[28], _potreros[4]);
            AsignarAnimalAPotrero(_animales[29], _potreros[4]);
            AsignarAnimalAPotrero(_animales[30], _potreros[4]);
            AsignarAnimalAPotrero(_animales[49], _potreros[5]);
            AsignarAnimalAPotrero(_animales[50], _potreros[5]);
        }

        public void AsignarAnimalAPotrero(Animal animal, Potrero potrero)
        {
            potrero.AsignarAnimal(animal);
        }

        public IEnumerable<Animal> FiltroAnimal(int peso, string tipo)
        {
            List<Animal> auxAnimales = new List<Animal>();

            foreach (Animal item in _animales)
            {
                if (item.Peso > peso && item.GetType().Name == tipo)
                {
                    auxAnimales.Add(item);
                }
            }
            return auxAnimales;
        }

        public Vacuna? ObtenerVacunaPorNombre(string TipoVacuna)
        {
            foreach (Vacuna item in _vacunas)
            {
                if (item.Nombre == TipoVacuna)
                {
                    return item;
                }
            }
            return null;
        }

        public void AgregarVacunaRecibida(VacunaRecibida vacunaRecibida)
        {
            if (vacunaRecibida == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            vacunaRecibida.Validar();
            _vacunasRecibidas.Add(vacunaRecibida);
        }

        public Animal? ObtenerAnimalPorCaravana(string caravana)
        {
            foreach (Animal item in _animales)
            {
                if (item.Caravana == caravana)
                {
                    return item;
                }
            }
            return null;
        }

        public Potrero? ObtenerPotreroPorId(int potrero)
        {
            foreach (Potrero item in _potreros)
            {
                if (item.Id == potrero)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
