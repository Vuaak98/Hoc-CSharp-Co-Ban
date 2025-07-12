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
* **1.4: Câu lệnh điều kiện `if-else`**
    * **Lý thuyết:**
        * Dùng để thực thi một khối lệnh nếu điều kiện là đúng (`true`), và một khối lệnh khác nếu điều kiện là sai (`false`).
        * **Toán tử so sánh:** `==` (bằng), `!=` (khác), `>` (lớn hơn), `<` (nhỏ hơn), `>=` (lớn hơn hoặc bằng), `<=` (nhỏ hơn hoặc bằng).
    * **Code thực hành:**
        ```csharp
        // Bai4_IfElse.cs
        ```
* **1.5: Câu lệnh `if-else if-else` & Git Branch**
    * **Lý thuyết:**
        * Dùng để xử lý các trường hợp có nhiều hơn 2 điều kiện.
        * `git checkout -b <ten-nhanh>`: Tạo và chuyển sang nhánh mới.
        * `git checkout <ten-nhanh>`: Chuyển qua lại giữa các nhánh.
        * `git merge <ten-nhanh>`: Gộp thay đổi từ nhánh khác vào nhánh hiện tại.
        * `git branch -d <ten-nhanh>`: Xóa nhánh (sau khi đã gộp).
    * **Code thực hành:**
        ```csharp
        // Bai5_IfElseIf.cs
        ```
* **1.6: Cấu trúc rẽ nhánh `switch-case`**
    * **Lý thuyết:**
        * Dùng để kiểm tra một biến với nhiều giá trị cụ thể. Thường gọn gàng hơn `if-else if` trong trường hợp này.
        * `case`: Mỗi trường hợp cần kiểm tra.
        * `break`: Ngắt luồng và thoát khỏi khối `switch`.
        * `default`: Trường hợp mặc định nếu không có `case` nào khớp.
    * **Code thực hành:**
        ```csharp
        // Bai6_SwitchCase.cs
        ```
* **1.7: Bài tập tổng hợp - Tính chỉ số BMI**
    * **Lý thuyết:**
        * Vận dụng kiến thức về biến, nhập liệu, ép kiểu và `if-else if-else`.
        * Công thức BMI: `Cân nặng (kg) / (Chiều cao (m) * Chiều cao (m))`.
    * **Code thực hành:**
        ```csharp
        // Bai7_BaiTapTongHopBMI.cs
        ```