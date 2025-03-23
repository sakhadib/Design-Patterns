# Singleton Pattern

## 1. Problem Statement

In many software systems, there are scenarios where only one instance of a class is required, and it should be accessible globally across the system. For example, in a mathematical application, you might need to calculate factorials multiple times. Instead of repeatedly creating new instances of the `Factorial` class, you may want to ensure that only one instance of the `Factorial` class is used throughout the application to save memory and ensure consistency.

Without a solution like the Singleton Pattern, you could end up creating multiple instances of the class, leading to unnecessary memory usage and possibly inconsistent behavior. The challenge is ensuring that the class is instantiated only once and providing a global access point to that instance.

## 2. Why Singleton is Used Here

The **Singleton Pattern** ensures that a class has only one instance and provides a global access point to that instance. It is particularly useful when:
- There is a need for a single, shared resource, such as a cache or a configuration object.
- It is important to control access to a resource that can be shared across the system.

In the case of the `Factorial` class, the Singleton pattern is used to ensure that only one instance of the `Factorial` class is created. This single instance manages a cache of precomputed factorial values, making the system more efficient by avoiding the need to compute the factorial of the same number repeatedly.

## 3. How Singleton is Implemented

In the Singleton Pattern, the key ideas are:

- **Private Constructor**: The constructor of the `Factorial` class is made private to prevent external instantiation of the class. This ensures that no other instances of the class can be created directly.

- **Static Instance**: A static field (`_instance`) is used to store the single instance of the class. This field is initialized lazily (i.e., only when it is needed) to ensure that the class is instantiated only once.

- **Global Access Method (`GetInstance`)**: A static method (`GetInstance`) is provided to allow global access to the unique instance. When this method is called, it checks if the instance already exists. If it does, it returns the existing instance. If it doesn't, it creates a new instance and returns it.

- **Singleton Instance Usage**: In the `main` method, the `GetInstance` method is called to obtain the unique `Factorial` instance, and the `GetFactorial` method is used to retrieve precomputed factorial values from the cache.

## 4. What Benefits Singleton Provides Here More Than Direct Instantiation

1. **Memory Efficiency**:
    - The Singleton Pattern ensures that only one instance of the `Factorial` class is created. This reduces memory usage because no additional instances are created, even if multiple parts of the program need to access the `Factorial` class.

2. **Consistency**:
    - By using a single instance, the Singleton Pattern ensures that the state of the `Factorial` class (in this case, the precomputed factorial cache) is consistent throughout the application. This eliminates the risk of having different copies of the class with different states.

3. **Global Access**:
    - The `GetInstance` method provides a global access point to the unique instance of the `Factorial` class. This allows various parts of the application to access the same instance without needing to pass it around or create multiple instances.

4. **Lazy Initialization**:
    - The Singleton instance is created only when it is first needed, which optimizes performance by avoiding unnecessary instantiations if the class is never used.

5. **Prevents Redundant Computations**:
    - Since the `Factorial` class caches the results of previous factorial calculations, the Singleton pattern ensures that subsequent requests for the same factorial values are retrieved quickly from the cache rather than being recomputed. This improves performance, especially for repeated calls to compute factorials.

### Conclusion

The **Singleton Pattern** is an essential design pattern when you need to ensure that only one instance of a class exists and that this instance is accessible globally. In the case of the `Factorial` class, it provides a highly efficient, memory-friendly solution for managing a shared resource (the factorial cache) while ensuring that the system operates consistently and avoids unnecessary computation.
