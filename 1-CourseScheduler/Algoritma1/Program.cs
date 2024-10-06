using Algoritma1;


CompLab[] complab = new CompLab[6] { new CompLab(40, "lab1"), new CompLab(60, "lab2"), new CompLab(40, "lab3"), new CompLab(60, "lab4"), new CompLab(40, "lab5"), new CompLab(60, "lab6") };

Course[] courses = new Course[10] { new Course(60, 2, "course1"), new Course(40, 2, "course2"), new Course(50, 2, "course3"), new Course(35, 2, "course4"), new Course(45, 2, "course5"), new Course(55, 2, "course6"), new Course(25, 2, "course7"), new Course(30, 2, "course8"), new Course(40, 2, "course9"), new Course(60, 2, "course10") };

Days[] days = new Days[5] { new Days("Pazartesi"), new Days("Salı"), new Days("Çarşamba"), new Days("Perşembe"), new Days("Cuma") };

foreach (var gun in days)
{
    Console.WriteLine(gun.name + "\n");

    // Hangi laboratuvarın müsait olduğunu hızlıca bulmak için önce listeyi güncelliyoruz
    List<CompLab> musaitLablar = complab.Where(lab => !lab.isFull).ToList();

    foreach (var course in courses)
    {
        if (course.isPlaced) continue;

        // İlk uygun laboratuvarı buluyoruz
        CompLab uygunLab = musaitLablar.FirstOrDefault(lab => course.quota <= lab.capacity && gun.maxDuration > 0);

        if (uygunLab != null)
        {
            uygunLab.isFull = true;
            course.isPlaced = true;
            gun.maxDuration -= 2;
            uygunLab.capacity -= course.quota;
            Console.WriteLine($"{course.name} başarıyla {uygunLab.name}'e eklendi ve {uygunLab.capacity} kişilik boş yer kaldı.");
            
            musaitLablar.Remove(uygunLab);
        }
        else if(uygunLab == null && gun.maxDuration > 0)
        {
            Console.WriteLine($"{course.name} için uygun laboratuvar bulunamadı.");
        }
        else
            Console.WriteLine("GÜNLÜK MAKSİMUM course SAATİNE ULAŞILDI, BUGÜNE DAHA FAZLA EKLENME YAPILAMIYOR!");
    }

    // Tüm laboratuvarların kapasitesini ve doluluk durumunu eski haline getiriyoruz
    foreach (var lab in complab)
    {
        lab.isFull = false;
        lab.capacity = lab.initialCapacity;
    }

    Console.WriteLine();
}
