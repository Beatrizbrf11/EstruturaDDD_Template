using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Data.Content
{
    //public class BaseContext<T> : DbContext where T : class
    //{
    //    public DbSet<T> DbSet
    //    {
    //        get;
    //        set;
    //    }
    //    public BaseContext() : base("EFConnectionString")
    //    {
    //        //Caso a base de dados não tenha sido criada, 
    //        //ao iniciar a aplicação iremos criar
    //        Database.SetInitializer<BaseContext<T>>(null);
    //    }

    //    protected override void  OnModelCreating(DbModelBuilder modelBuilder)
    //    {

    //        //Neste momento não iremos fazer nada, 
    //        //iremos voltar mais para frente para criar nosso mapeamos dinamicos
    //        base.OnModelCreating(modelBuilder);
    //    }

    //    public virtual void ChangeObjectState(object model, EntityState state)
    //    {
    //        //Aqui trocamos o estado do objeto, 
    //        //facilita quando temos alterações e exclusões
    //        ((IObjectContextAdapter)this)
    //                      .ObjectContext
    //                      .ObjectStateManager
    //                      .ChangeObjectState(model, state);
    //    }

    //public virtual int Save(T model)
    //{
    //    this.DbSet.Add(model);
    //    return this.SaveChanges();
    //}

    //public virtual int Update(T model)
    //{
    //    var entry = this.Entry(model);
    //    if (entry.State == EntityState.Detached)
    //        this.DbSet.Attach(model);

    //    this.ChangeObjectState(model, EntityState.Modified);
    //    return this.SaveChanges();
    //}

    //public virtual void Delete(T model)
    //{
    //    var entry = this.Entry(model);
    //    if (entry.State == EntityState.Detached)
    //        this.DbSet.Attach(model);

    //    this.ChangeObjectState(model, EntityState.Deleted);
    //    this.SaveChanges();
    //}

    //public virtual IEnumerable<T> GetAll()
    //{
    //    return this.DbSet.ToList();
    //}

    //public virtual T GetById(object id)
    //{
    //    return this.DbSet.Find(id);
    //}

    //public virtual IEnumerable<T> Where(Expression<Func<T, bool>> expression)
    //{
    //    return this.DbSet.Where(expression);
    //}

    //public IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression)
    //{
    //    return this.DbSet.OrderBy(expression);
    //}
    //}
}