using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
클래스1, 클래스2 가 있을 때 
클래스1 생성자에서 클래스2의 인스턴스를 생성
클래스2 생성자에서 클래스1의 인스턴스를 생성
클래스1 인스턴스 생성 → 클래스2 인스턴스 생성 → 클래스1 인스턴스 생성 → 계속 반복
> 스택이 초과되고 StackOverflowException이 발생
= 싱글톤 사용
*/
namespace Singleton_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2번 호출
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            // 2번 다 같은 _instance 호출
            if (s1 == s2)
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }
        }
    }
    public class Singleton
    {
        // 객체 선언 못 하게
        private Singleton() { }
        private static Singleton _instance;    // 싱글톤 인스턴스를 저장하는 정적 필드

        private static readonly object _lock = new object();

        // _instance 를 사용할 수 있는 method 를 만든다
        public static Singleton GetInstance()    // 인스턴스에 접근하기 위한 정적 프로퍼티
        {
            // Thread in safe
            if(_instance == null)
            {
                lock(_lock)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
}
