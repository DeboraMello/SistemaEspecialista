namespace sistemaEspecialista
{
    class SuitabilityForm
    {
        public static void run()
        {
            Form form = new Form().generateForm();
            
            form.processForm(form);
        } 
    }
}
