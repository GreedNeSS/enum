enum FileAccess {
	Read = 3, Write,
	ReadWrite = Read + Write,
}

const value1 = FileAccess.Read;
const value2 = FileAccess.Write;
const value3 = FileAccess.ReadWrite;

console.dir(FileAccess);
console.dir({ value1, value2, value3 });