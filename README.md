# PrioryTask
Final Project Struktur Data 

Anggota: 
- Lucky Virgiawan Dwi Widodo 5053231007
- Dipta Sena Alfarehzi Djomi 5053231033

Cara Kerja dalam Aplikasi PrioryTask\n
Aplikasi PrioryTask menggunakan LinkedList untuk menyimpan tugas dan Queue untuk mengelola urutan tugas yang harus diselesaikan. Berikut adalah penjelasan detail tentang bagaimana kedua struktur data ini bekerja sama dalam aplikasi ini.
Menyimpan Data Tugas dengan LinkedList
Penyimpanan: Setiap tugas yang ditambahkan oleh pengguna disimpan dalam node LinkedList.
Operasi Penambahan: Saat pengguna menambahkan tugas, aplikasi membuat node baru dalam LinkedList dan menambahkan deskripsi tugas ke node tersebut.
Contoh:
Node 1: "Tugas 1"
Node 2: "Tugas 2"
Node 3: "Tugas 3"
Mengelola Urutan Tugas dengan Queue
Penyimpanan Referensi: Queue menyimpan referensi ke node-node dalam LinkedList.
Operasi Penambahan: Setiap kali tugas baru ditambahkan ke LinkedList, referensi ke node tugas tersebut juga ditambahkan ke Queue.
Operasi Penghapusan: Ketika pengguna menyelesaikan tugas, referensi node pertama dikeluarkan dari Queue dan node tersebut dihapus dari LinkedList.
Contoh:
Front -> Node 1: "Tugas 1"
Node 2: "Tugas 2"
Rear -> Node 3: "Tugas 3"



1. Program.cs
Ini adalah titik masuk utama aplikasi yang mengatur alur utama aplikasi CLI. Kode ini berisi logika untuk menampilkan menu dan memanggil fungsi yang sesuai berdasarkan pilihan pengguna.
Main Method
Fungsi: Menampilkan menu kepada pengguna dan memanggil metode yang sesuai berdasarkan pilihan pengguna.
Alur:
Membuat instance dari TaskManager.
Menampilkan menu pilihan kepada pengguna.
Berdasarkan input pengguna, memanggil metode yang sesuai untuk mengelola tugas.
Terus berulang sampai pengguna memilih untuk keluar.
2. TaskManager.cs
TaskManager adalah kelas utama yang mengelola daftar tugas menggunakan struktur data LinkedList dan Queue. Semua operasi yang berkaitan dengan tugas didefinisikan dalam kelas ini.
Constructor
Fungsi: Menginisialisasi LinkedList dan Queue untuk menyimpan dan mengelola tugas.
Alur: Membuat LinkedList untuk menyimpan deskripsi tugas dan Queue untuk mengelola urutan tugas.
AddTask
Fungsi: Menambahkan tugas baru ke dalam daftar.
Parameter: string taskDescription - deskripsi tugas yang akan ditambahkan.
Alur:
Menambahkan tugas baru ke dalam LinkedList.
Menambahkan referensi node tugas baru ke dalam Queue.
Menampilkan pesan konfirmasi.
CompleteTask
Fungsi: Menyelesaikan tugas pertama dari daftar (menghapus tugas dari daftar).
Alur:
Memeriksa apakah Queue tidak kosong.
Menghapus tugas pertama dari Queue dan LinkedList.
Menampilkan pesan konfirmasi.
Jika Queue kosong, menampilkan pesan bahwa tidak ada tugas yang dapat diselesaikan.
DisplayTasks
Fungsi: Menampilkan semua tugas yang ada dalam daftar.
Alur:
Memeriksa apakah LinkedList tidak kosong.
Menampilkan semua tugas dalam LinkedList.
Jika LinkedList kosong, menampilkan pesan bahwa tidak ada tugas yang tersedia.
ViewNextTask
Fungsi: Menampilkan tugas berikutnya yang harus diselesaikan tanpa menghapusnya dari daftar.
Alur:
Memeriksa apakah Queue tidak kosong.
Menampilkan tugas pertama dalam Queue tanpa menghapusnya.
Jika Queue kosong, menampilkan pesan bahwa tidak ada tugas yang tersedia.
CheckIfTaskListIsEmpty
Fungsi: Memeriksa apakah daftar tugas kosong atau tidak.
Alur:
Memeriksa apakah LinkedList kosong.
Menampilkan status dari daftar tugas (kosong/tidak kosong).
GetTaskCount
Fungsi: Menghitung dan menampilkan jumlah tugas dalam daftar.
Alur: Menghitung jumlah tugas dalam LinkedList dan menampilkan hasilnya.
3. AddTask.cs
Kelas ini mengelola penambahan tugas ke dalam daftar.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Meminta deskripsi tugas dari pengguna dan menambahkannya ke dalam TaskManager.
Alur:
Meminta deskripsi tugas dari pengguna.
Memanggil metode AddTask dari TaskManager untuk menambahkan tugas ke dalam daftar.
4. CompleteTask.cs
Kelas ini mengelola penyelesaian tugas pertama dalam daftar.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Menghapus tugas pertama dari TaskManager.
Alur: Memanggil metode CompleteTask dari TaskManager untuk menghapus tugas pertama dari daftar.
5. DisplayTasks.cs
Kelas ini mengelola penampilan semua tugas dalam daftar.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Menampilkan semua tugas dalam TaskManager.
Alur: Memanggil metode DisplayTasks dari TaskManager untuk menampilkan semua tugas yang ada dalam daftar.
6. ViewNextTask.cs
Kelas ini mengelola penampilan tugas berikutnya tanpa menghapusnya dari daftar.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Menampilkan tugas berikutnya dari TaskManager tanpa menghapusnya.
Alur: Memanggil metode ViewNextTask dari TaskManager untuk menampilkan tugas berikutnya dalam daftar.
7. CheckIfTaskListIsEmpty.cs
Kelas ini mengelola pemeriksaan apakah daftar tugas kosong atau tidak.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Memeriksa apakah daftar tugas dalam TaskManager kosong.
Alur: Memanggil metode CheckIfTaskListIsEmpty dari TaskManager untuk memeriksa status daftar tugas.
8. GetTaskCount.cs
Kelas ini mengelola penampilan jumlah tugas dalam daftar.
Constructor
Fungsi: Menerima instance TaskManager sebagai parameter.
Execute
Fungsi: Menampilkan jumlah tugas dalam TaskManager.
Alur: Memanggil metode GetTaskCount dari TaskManager untuk menghitung dan menampilkan jumlah tugas dalam daftar.
