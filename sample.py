import sys
if __name__ == '__main__':
    f = open(sys.argv[1], 'r')
    s = f.read()
    f.close()
    print(s)