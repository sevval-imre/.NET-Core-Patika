﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
	public class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("**** SORU-1 ****");
            Console.WriteLine(" Pozitif Bir Sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <0 || n==0){
                Console.WriteLine("Lütfen Pozitif bir sayı giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            else{
                int[] sayilar = new int[n];
                for(int i = 0; i<n; i++){
                    Console.WriteLine((i+1) + ". sayıyı giriniz: ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Çift Sayılar: ");
                for(int i=0; i<n; i++){
                    if(sayilar[i]%2==0){
                        Console.Write(sayilar[i] + " ");
                    }
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("**** SORU-2 ****");
            Console.WriteLine(" Pozitif İki Adet Sayı giriniz: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            if((N <0 || N==0) || (M<0 || M==0)){
                Console.WriteLine("Lütfen Pozitif İki Adet sayı giriniz: ");
                N = Convert.ToInt32(Console.ReadLine());
                M = Convert.ToInt32(Console.ReadLine());
            }
            else{
                int[] dizi = new int[N];
                for(int i = 0; i<N; i++){
                    Console.WriteLine((i+1) + ". sayıyı giriniz: ");
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(M + " sayısına eşit veya tam bölünen sayılar: ");
                for(int i = 0; i<N; i++){
                    if(dizi[i] == M || dizi[i]%M==0){
                        Console.Write(dizi[i] + " ");
                    }
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("**** SORU-3 ****");
            Console.WriteLine(" Pozitif Bir Sayı giriniz: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if(k <0 || k==0){
                Console.WriteLine("Lütfen Pozitif bir sayı giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            else{
                string[] word = new string[k];
                for(int i =0; i<k; i++){
                    Console.WriteLine((i+1) + ". kelimeyi giriniz");
                    word[i]=Console.ReadLine();
                }
                Console.WriteLine("Kelimelerin tersten sıralanışı");
                Array.Reverse(word);
                for(int i =0; i<k; i++){
                    Console.WriteLine(word[i]+" ");
                    
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("**** SORU-4 ****");
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            int harf = cumle.Length;
            string[]kelimeler = cumle.Split(' ');
            int bosluksuzHarf = harf - (kelimeler.Length - 1);
            Console.WriteLine("Cümledeki kelime sayısı: " + kelimeler.Length  +"\nCümledeki harf sayısı: " + bosluksuzHarf);

            Console.ReadKey();
        }
    }
}