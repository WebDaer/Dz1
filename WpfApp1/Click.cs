﻿using System;
using System.Windows.Controls;

 class Click

{
	private void Cliar(Label a)// Инкапсуляция
    {
		a.Content = "";
    }
	
	public virtual void Clicken(Label a)
    {
		string b = Convert.ToString(a.Content);
		if (b != "")
        {
			Cliar(a);//Могу использовать только в этом клссе
        }
        else
        {
			a.Content = "Кнопка работает";
		}
	}
}
class NClick : Click // Наследование Это копирование всех методов, переменных, функций из другого класса
{

}
class UpdateClick : NClick //Полиморфизм
{
    public override void Clicken(Label a)
    {
        a.Content = "Кнопка всегда работает";
    }
    
}
