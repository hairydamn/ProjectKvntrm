
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Kvantorium_Project
{

using System;
    using System.Collections.Generic;
    
public partial class PeredachaOborud
{

    public int Id { get; set; }

    public int IdFirstSotr { get; set; }

    public int IdSecondSotr { get; set; }

    public int IdObor { get; set; }

    public string PurposePeredacha { get; set; }



    public virtual Oborud Oborud { get; set; }

    public virtual Sotrud Sotrud { get; set; }

    public virtual Sotrud Sotrud1 { get; set; }

}

}
