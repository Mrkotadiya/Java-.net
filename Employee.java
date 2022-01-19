//net salary= gross salary-deducation
////gross salary=basic+medical9++hra+da
//da=15%of basic
//hra=10%of basic
//medical=4% of basic
//pf= 5% of basic
//insurance=7% gross 



class Employee
{
	public static void main(String ags[])
	{
		float basic_salary,da,hra,dra1,hra1,gorss_payment;
		scanner scane =new scanner(system.in);

		
		System.out.println("Enter basic salary of Employee");
		basic_salary=scan.nextfloat();
		
		
		System.out.println("Enter basic DA of Employee");
		dra1=scan.nextfloat();
		
		System.out.println("Enter basic HRA of Employee");
		hra1=scan.nextfloat();
		
		da=(dra1*basic_salary)/100;
		hra=(hra1*basic_salary)/100;
		
		gorss_payment=basic_salary+da+hra;
		
		System.out.println("Gross Salary of EMployee "+gorss_payment);
		
		}
	
}