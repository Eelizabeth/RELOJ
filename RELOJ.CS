using System;
namespace Practica2
{
  public class Reloj
	{	
		private int horas;
		private int minutos;
		private int segundos;
		private Utilerias utilerias;

		public Reloj ()
		{
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
			this.utilerias = new Utilerias();
		}

		public void iniciar(){
			this.obtenHoraLocal();
			this.iniciaProceso();
		}

		private void obtenHoraLocal(){
			this.horas = DateTime.Now.Hour;
			this.minutos = DateTime.Now.Minute;
			this.segundos = DateTime.Now.Second;
		}
