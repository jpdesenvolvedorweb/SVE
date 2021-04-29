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
                    throw new Exception("Precisar ser informada uma descrição valida para a categoria!!!");

                if (this.Name.Length > max)
                    throw new Exception("A descrição da categoria não pode ser maior que setenta caracteres!!!");


                this.Id = new Database.Category().Save(this.Name, this.Description);
            }
            catch (Exception erro)
            {

            }
        }

        public static List<Category> List()
        {
            var categories = new List<Category>();
            DataTable dice = new Database.Category().List();

            for (var i =0; i< dice.Rows.Count; i++)
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
    }
}
