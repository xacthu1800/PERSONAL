#Lab02
#1. Define a function that return the sum of two numbers a and b. Try with a = 3, b = 4
def sum(a,b):
    return a + b
print('Cau 1')
print(sum(3,4), end= '\n\n')

#2. Create a 3x3 matrix and vector v = {1,2,3}. And check the rank, the shape of this matrix and vector x
import numpy as np
index = np.array([[1,2,3], [4,5,6], [7,8,9]])
print('Cau 2')
print(index, end= '\n\n')

#3. Create a new 3x3 matrix such that it's elements are the sum of corresponding (position)
# element of M plus 3
index = np.array([[1,2,3], [4,5,6], [7,8,9]])
x = index + 3
print('Cau 3')
print(x, end= '\n\n')

#4. Create the transpose of M and v  // đảo ma trận  
index = np.array([[1,2,3], [4,5,6], [7,8,9]])
print('Cau 4')
print(index.transpose(1,0), end= '\n\n')

#5. Compute the norm of x=(2,7). Normalization vector x
x = np.array([2,7])
norm_x = np.linalg.norm(x)
normalize = x/norm_x
print('Cau 5')
print('Vector x:', x)
print('Norm of x', norm_x)
print('Normalization of x', normalize, end= '\n\n')

#6. Given a=[10,15], b=[8,2], c=[1,2,3]. Compute a+b, a-b, a-c
a = np.array([10,15])
b = np.array([8,2])
c = np.array([1,2,3])
sumab = a+b
minusab = a-b

print('Cau 6')
print(sumab)
print(minusab, end= '\n\n')

#7. Compute the dot product of a and b
a = np.array([10,15])
b = np.array([8,2])

print('Cau 7')


#8. Given matrix A={[2,4,9],[3,6,7]}
A = np.array([[2,4,9], [3,6,7]])
print('Cau 8')
#a. Check the rank and shape of A
print('Matrix rank:', np.linalg.matrix_rank(A))
print(A)
#b. How to get the value 7 in A
print(A[1,2])
#c. Return the second column of A
print(A[1,:],end= '\n\n')

#9. Create a random 3x3 matrix with the value in range (-10,10)
rand = np.random.randint(low=-10, high=10, size=(3,3))
print('Cau 9')
print(rand, end= '\n\n')

#10. Create an identity (3x3) matrix
iden = np.identity(3)
print('Cau 10')
print(iden, end= '\n\n')

#11. Create a random 3x3 matrix with the value in range (1,10). Compute the trace of this matrix by 2 ways
rand11 = np.random.randint(low=1, high=10, size=(3,3))
print('Cau 11')
#a. By one command
print(rand11)
trace1 = np.trace(rand11)
print(trace1, '\n\n')
#b. By using for loops


#12. Create a 3x3 matrix with the value in main diagonal 1,2,3
a = np.full((3,3), 2)
print(a)
v = [1,2,3]
diag12 = np.fill_diagonal(a,v)
print(diag12, '\n\n')


# Create a 3x3 matrix with values 1, 2, 3 in the main diagonal GPT
print('GPT cau 12 start here')
matrix = np.diag([1, 2, 3])

print(matrix)