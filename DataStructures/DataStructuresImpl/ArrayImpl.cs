namespace DataStructures.DataStructuresImpl;

public class ArrayImpl
{
    private object?[] _array;
    private int _capacity => _array.Length;
    private int _size = 0;
    public ArrayImpl()
    {
        _array = Array.Empty<object?>();
    }

    public ArrayImpl(int capacity)
    {
        _array = new object?[capacity];
    }

    public int Size() => _size;
    public int Capacity() => _capacity;
    public bool IsEmpty() => _size == 0;
    
    public void PushOrAdd(object? item)
    {
        EnsureCapacity();
        _array[_size++] = item;
    }

    private void EnsureCapacity()
    {
        void Resize(int newCapacity)
        {
            var newArray = new object?[newCapacity];
            for (int i = 0; i < _capacity; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        if (_size + 1 == _capacity)
        {
            Resize(_capacity * 2);
        }
    }

    public void Insert(object item, int index)
    {
        // _size++;
        //
        // if(_size == _capacity)
        // {
        //     Resize(_capacity * 2);
        // }
        //
        // for (int i = index + 1; i < _size; i++)
        // {
        //     _array[i] = _array[i - 1];
        // }
        //
        // _array[index] = item;
    }
    
    public object? AtIndex(int index)
    {
        if (index < 0 || index >= _capacity)
        {
            throw new IndexOutOfRangeException();
        }
        
        return _array[index];
    }

    public object? Pop()
    {
        // if (_size == 0)
        // {
        //     throw new IndexOutOfRangeException();
        // }
        //
        // object? value = _array[--_size]
        // _array[_capacity - 1] = null;
        // return value;
    }

    public int Find(object? item)
    {
        for (int i = 0; i < _capacity; i++)
        {
            if (_array[i] == item)
            {
                return i;
            }
        }

        return -1;
    }
}