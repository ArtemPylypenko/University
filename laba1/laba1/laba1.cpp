#include <iostream>
#include <vector>


using namespace std;



struct Node {
	int vertexIndex;
	vector<Node> neighbors;
};

struct Graph {
	vector<Node> vertex;


	void show() {
		for (int i = 0; i < vertex.size(); i++) {
			cout << vertex[i].vertexIndex << " ";
		}
		cout << endl;
		for (int i = 0; i < vertex.size(); i++) {
			cout << vertex[i].vertexIndex << "-->";
			for (int j = 0; j < vertex[i].neighbors.size(); j++) {
				cout << vertex[i].neighbors[j].vertexIndex << " ";
			}
			cout << endl;
		}
		cout << endl;
	}

	void addVertex(int index) {
		for (int i = 0; i < vertex.size(); i++) {
			if (index == vertex[i].vertexIndex) {
				cout << "such a vertex already exists" <<"("<<index<<")"<< endl;
				return;
			}
		}
		Node newVertex;
		newVertex.vertexIndex = index;
		vertex.push_back(newVertex);
	}

	void addEdge(int index1,int index2) {
		bool exist1 = false;
		bool exist2 = false;
		Node first;
		Node second;
		for (int i = 0; i < vertex.size(); i++) {
			if (index1 == vertex[i].vertexIndex) {
				exist1 = true;
				first = vertex[i];
			}
			if (index2 == vertex[i].vertexIndex) {
				exist2 = true;
				second= vertex[i];
			}
		}
		if (exist1 == false) {
			cout << "No firts edge" << endl;
			return;
		}
		if (exist2 == false) {
			cout << "No second edge" << endl;
			return;
		}
		for (int i = 0; i < vertex.size(); i++) {
			if (index1 == vertex[i].vertexIndex) {
				vertex[i].neighbors.push_back(second);

			}
			if (index2 == vertex[i].vertexIndex) {
				exist2 = true;
				vertex[i].neighbors.push_back(first);
			}
		}
	}

	void deleteEdge(int index1, int index2) {
		for (int i = 0; i < vertex.size(); i++) {
			if (vertex[i].vertexIndex == index1) {
				for (int j = 0; j < vertex[i].neighbors.size(); j++) {
					if (vertex[i].neighbors[j].vertexIndex == index2) {
						vertex[i].neighbors.erase(vertex[i].neighbors.begin() + j);
					}
				}
			}
			if (vertex[i].vertexIndex == index2) {
				for (int j = 0; j < vertex[i].neighbors.size(); j++) {
					if (vertex[i].neighbors[j].vertexIndex == index1) {
						vertex[i].neighbors.erase(vertex[i].neighbors.begin() + j);
					}
				}
			}
		}
	}

	void deleteVertex(int index) {
		int i = 0;
		while (index != vertex[i].vertexIndex) {
			i++;
		}
		int j = 0;
		while (j < vertex[i].neighbors.size()) {
			this->deleteEdge(index, vertex[i].neighbors[j].vertexIndex);
		}
		vertex.erase(vertex.begin() + i);
	}

};

void deep(Node &vertex, vector<int>& visited, Graph& tree, Graph Graph) {
	visited.push_back(vertex.vertexIndex);
	for (int i = 0; i < vertex.neighbors.size(); i++) {
		bool isVisisted = false;
		for (int j = 0; j < visited.size(); j++) {
			if (vertex.neighbors[i].vertexIndex == visited[j]) {
				isVisisted = true;
			}
		}
		if (isVisisted != true) {
			Node next;
			for (int k = 0; k < Graph.vertex.size(); k++) {
				if (vertex.neighbors[i].vertexIndex == Graph.vertex[k].vertexIndex) {
					next = Graph.vertex[k];
				}
			}
			
			tree.addEdge(vertex.vertexIndex, vertex.neighbors[i].vertexIndex);
			deep(next, visited, tree, Graph);
		}
	}
	if (visited.size() < Graph.vertex.size()) {
		for (int i = 0; i < Graph.vertex.size(); i++) {
			bool isVisited = false;
			for (int j = 0; j < visited.size(); j++) {
				if (Graph.vertex[i].vertexIndex == visited[j]) {
					isVisited = true;
				}
			}
			if (isVisited == false) {
				deep(Graph.vertex[i],visited,tree,Graph);
			}
		}
	}
}
int main() {
	
	Graph myGraph;
	
	bool exit = false;
	while (!exit) {
		cout << "1-add vertex" << endl;
		cout << "2-add edge" << endl;
		cout << "3-show" << endl;
		cout << "4-deep"<< endl;
		cout << "5-exit"<< endl;
		int operation;
		cin >> operation;
		switch (operation)
		{
		default:
			break;
		case 1:
		{
			cout << "enter vertex index " << endl;
			int vertex;
			cin >> vertex;
			myGraph.addVertex(vertex);
		}
		case 2:
		{
			cout << "enter vertex1 index and vertex2 index " << endl;
			int vertex1;
			int vertex2;
			cin >> vertex1>>vertex2;
			myGraph.addEdge(vertex1, vertex2);
		}
		case 3:
		{
			myGraph.show();
		}
		case 4:
		{
			Graph skeletaLtree;
				for (int i = 0; i < myGraph.vertex.size(); i++) {
					skeletaLtree.addVertex(myGraph.vertex[i].vertexIndex);
				}
	
				vector<int> visited;
				cout << endl;
	
				deep(myGraph.vertex[0], visited, skeletaLtree, myGraph);
				skeletaLtree.show();
		}
		case 5:
		{

			exit=true;
		}
		}
	}
	


	
	
	system("pause");
	return 0;
}

