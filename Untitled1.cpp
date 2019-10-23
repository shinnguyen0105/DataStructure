
#include <iostream> 
using namespace std; 
int main() 
{ 
  int arr[5]; 
   cout<<"Nhap 5 so nguyen\n"; 
  for(int l=0;l<5;l++) {
     cout<<"Gia tri "<<l<<" la :";cin>>arr[l]; 
	}  

//giatrinhonhat
 int i, min, tong = 0; 

 for(i=0;i<5;i++)
 {
	tong += arr[i];
 }
  for(i=0;i<5;i++)
     if (min > arr[i]) min = arr[i];
  //Tongcuacacphantu
      	cout<<"Gia tri nho nhat="<<arr[0]; 
 		cout<<"\n"; 
  		cout<<"Tong cac phan tu trong mang la:"<<tong;
}



    
