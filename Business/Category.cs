using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Category : IInitial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateRegister { get; set; }

        public void Save()
        {
            const int min = 40;
            const int max = 70;

            try
            {
                if (string.IsNullOrWhiteSpace(this.Name))
                    throw new Exception("Por favor digite um nome valido para a categoria!!!");

                if (this.Name.Length > min)
                    throw new Exception("O nome da categoria não pode ser maior que quarenta caracteres!!!");

                if (string.IsNullOrWhiteSpace(this.Description))
                    throw new Exception("Precisa ser informada uma descrição valida para a categoria!!!");

                if (this.Description.Length >= max)
                    throw new Exception("A descrição da categoria não pode ser maior que setenta caracteres!!!");

                if (this.Id > 0)
                {
                    new Database.Category().Alter(this.Id, this.Name, this.Description);
                    return;
                }

                this.Id = new Database.Category().Save(this.Name, this.Description);
            }
            catch (Exception erro)
            {
                Message.Take(erro.Message);
            }
        }

        public static List<Category> List()
        {
            var categories = new List<Category>();
            DataTable dice = new Database.Category().List();

            for (var i = 0; i < dice.Rows.Count; i++)
            {
                categories.Add(new Category
                {
                    Id = Convert.ToInt32(dice.Rows[i]["id"]),
                    Name = dice.Rows[i]["nome"].ToString(),
                    Description = dice.Rows[i]["descricao"].ToString(),
                    DateRegister = dice.Rows[i]["data_cadastro"].ToString()
                });
            }
            return categories;
        }

        public Category List(int id)
        {
            var categorie = new Category();
            DataTable dice = new Database.Category().List(id);
            try
            {
                if (dice.Rows.Count == 0)
                    throw new Exception($"Não existe categoria cadastrada com o id = {id}!!!");

                if (dice.Rows.Count > 1)
                    throw new Exception($"Erro interno do sistema, o id = {id} foi cadastrado mais de uma vez recomendo acionar o suporte técnico!!!");

                for (var i = 0; i < dice.Rows.Count; i++)
                {
                    categorie.Id = Convert.ToInt32(dice.Rows[i]["id"]);
                    categorie.Name = dice.Rows[i]["nome"].ToString();
                    categorie.Description = dice.Rows[i]["descricao"].ToString();
                    categorie.DateRegister = dice.Rows[i]["data_cadastro"].ToString();
                }
            }
            catch (Exception erro)
            {
                Message.Take(erro.Message);
            }

            return categorie;
        }

        public void Delete()
        {
            try
            {
                if (List(this.Id) == null)
                    throw new Exception($"A categoria com o id = {this.Id} é inexistente ou já foi exclúida!!!");

                new Database.Category().Delete(this.Id);
            }
            catch (Exception erro)
            {
                Message.Take(erro.Message);
            }

        }

    }
}
