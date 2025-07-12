### Bài 1: C# Cơ bản

* **1.1: Hello World & Vòng lặp Git**
    * **Lý thuyết:**
        * `Console.WriteLine()`: In một dòng chữ ra màn hình rồi tự động xuống hàng.
        * `Console.Write()`: In một dòng chữ ra màn hình nhưng **không** xuống hàng.
        * `Console.ReadKey()`: Dừng màn hình, chờ người dùng bấm một phím bất kỳ.
        * `Console.ReadLine()`: Đọc một dòng văn bản do người dùng nhập vào.
        * **Git workflow:** `git status` -> `git add .` -> `git commit -m "..."` -> `git push`.
    * **Code thực hành:**

* **1.2: Biến, Kiểu dữ liệu & Nhận dữ liệu**
    * **Lý thuyết:**
        * **Biến (Variable):** Giống như một cái hộp có nhãn để lưu trữ dữ liệu.
        * **Kiểu dữ liệu (Data Type):**
            * `string`: Dùng để lưu văn bản, chữ viết (đặt trong `""`).
            * `int`: Dùng để lưu số nguyên (không có dấu phẩy).
            * `float`, `double`: Dùng để lưu số thực (có dấu phẩy).
        * **Nhận dữ liệu:** Dùng `Console.ReadLine()` để đọc một chuỗi từ người dùng.
        * **Ép kiểu (Parsing):**
            * `int.Parse()`: Chuyển chuỗi thành số nguyên.
            * `float.Parse()`: Chuyển chuỗi thành số thực.
    * **Code thực hành:**
* **1.3: Phép toán và Ép kiểu**
    * **Lý thuyết:**
        * **Toán tử số học:** `+` (cộng), `-` (trừ), `*` (nhân), `/` (chia), `%` (chia lấy dư).
        * **Chia số nguyên:** Khi chia 2 số `int`, kết quả sẽ tự động bị cắt bỏ phần thập phân (ví dụ: `5 / 2` sẽ bằng `2`).
        * **Ép kiểu (Type Casting):** Dùng `(float)` hoặc `(double)` đứng trước một biến số nguyên để tạm thời coi nó là số thực, giúp phép chia cho ra kết quả đúng.
    * **Code thực hành:**
