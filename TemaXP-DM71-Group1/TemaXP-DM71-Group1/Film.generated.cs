#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;


namespace TemaXP_DM71_Group1	
{
	public partial class Film
	{
		private int id;
		public virtual int Id 
		{ 
		    get
		    {
		        return this.id;
		    }
		    set
		    {
		        this.id = value;
		    }
		}
		
		private string releaseDate;
		public virtual string ReleaseDate 
		{ 
		    get
		    {
		        return this.releaseDate;
		    }
		    set
		    {
		        this.releaseDate = value;
		    }
		}
		
		private string title;
		public virtual string Title 
		{ 
		    get
		    {
		        return this.title;
		    }
		    set
		    {
		        this.title = value;
		    }
		}
		
		private string distributor;
		public virtual string Distributor 
		{ 
		    get
		    {
		        return this.distributor;
		    }
		    set
		    {
		        this.distributor = value;
		    }
		}
		
		private string arrivalDate;
		public virtual string ArrivalDate 
		{ 
		    get
		    {
		        return this.arrivalDate;
		    }
		    set
		    {
		        this.arrivalDate = value;
		    }
		}
		
		private string returnDate;
		public virtual string ReturnDate 
		{ 
		    get
		    {
		        return this.returnDate;
		    }
		    set
		    {
		        this.returnDate = value;
		    }
		}
		
		private string duration;
		public virtual string Duration 
		{ 
		    get
		    {
		        return this.duration;
		    }
		    set
		    {
		        this.duration = value;
		    }
		}
		
		private string director;
		public virtual string Director 
		{ 
		    get
		    {
		        return this.director;
		    }
		    set
		    {
		        this.director = value;
		    }
		}
		
		private string actors;
		public virtual string Actors 
		{ 
		    get
		    {
		        return this.actors;
		    }
		    set
		    {
		        this.actors = value;
		    }
		}
		
		private string movieDescription;
		public virtual string MovieDescription 
		{ 
		    get
		    {
		        return this.movieDescription;
		    }
		    set
		    {
		        this.movieDescription = value;
		    }
		}
		
		private IList<Show> shows = new List<Show>();
		public virtual IList<Show> Shows 
		{ 
		    get
		    {
		        return this.shows;
		    }
		}
		
	}
}
