// Khai báo lại cái URL trỏ về Backend C#
const BASE_URL = 'https://localhost:7000/api';

/**
 * Gọi API Đăng ký người dùng mới
 */
export async function registerUser(userData) {
  try {
    const response = await fetch(`${BASE_URL}/auth/register`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      // Chuyển cục data của ông thành chuỗi JSON để gửi đi
      body: JSON.stringify(userData),
    });

    if (!response.ok) {
      const errorData = await response.json().catch(() => ({}));
      throw new Error(errorData.message || `Lỗi server: ${response.status}`);
    }

    return await response.json(); 
    
  } catch (error) {
    console.error("Lỗi khi gọi API Đăng ký:", error.message);
    throw new Error(error.message || "Không thể kết nối đến máy chủ. Vui lòng thử lại sau!");
  }
}