//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase_First.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sportsmen
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int Country_Id { get; set; }
        public int Sports_Id { get; set; }
        public int ResultOfCompetition { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Sport Sport { get; set; }
    }
}
