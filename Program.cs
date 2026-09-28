namespace Session01_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // a) the DeliveryAddress variable is struct (value type) so its new copy has the value of DeliveryAddress variable,
            // and when the copy is modifed so the copy only has the modify but DeliveryAddress variable has its same value not
            // changed

            // b) the Customer variable is class (reference type) so its new copy refere to the same object that Customer variable
            // refere to, and when one variable modifies the object so the two variables will be modified
            #endregion
            #region Q2
            // a) 1- any change in the variables name will appear out to all solution,
            //    2- we can not make validation on fields,
            //    3- we can not allow getter and prevent setter and vise versa

            // b) when we make fields private so no class can show them, and propirtes only will be shown, so any modification in fields
            // will not be shown outside, we can make validations in properties, and can allow getter and prevent setter and vise versa
            #endregion

            #endregion

            


        }
    }

    
}
